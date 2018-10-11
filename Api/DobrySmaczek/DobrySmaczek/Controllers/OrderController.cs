using DobrySmaczek.Entities;
using DobrySmaczek.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;

namespace DobrySmaczek.Controllers
{
    public class OrderController
    {
        private readonly DataBaseContext context;
        public OrderController(DataBaseContext context)
        {
            this.context = context;
        }
        public IEnumerable<Order> GetOrders()
        {
            return context.Orders.Where(o => o.UserId == User.Id.Name);
        }
        public Order GetOrder(int id)
        {
            Order order = context.Orders.Include("OrderDetails.Meal")
                .First(o => o.Id == id && o.UserId == User.Id.Name);
            if (order == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return new Order()
            {
                Details = from d in order.OrderDetails
                          select new Order.Detail()
                          {
                              Id = d.Meal.Id,
                              Meal = d.Meal.Name,
                              UserId = d.Meal.UserId,
                              DeliveryCosts = d.DeliveryCosts,
                              TotalAmount = d.TotalAmount
                              
                          }
            };
        }

    }
}

using DobrySmaczek.Entities;
using DobrySmaczek.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DobrySmaczek.Services.Order
{
    public class OrderService
    {
        private DataBaseContext _context;

        public OrderService(DataBaseContext context)
        {
            _context = context;
        }

        public List<AppOrder> GetAll()
        {
            return _context.Orders.ToList();
        }

        public AppOrder GetById(int id)
        {
            return _context.Orders.SingleOrDefault(x => x.Id == id);

        }

        //public AppOrder Create(AppOrder AppOrders, Users user)
        //{
        //    var order = _context.AppOrders.Find(AppOrders.Id);
        //    if(order == null)
        //        throw new AppException("Order not found");
        //    if(AppOrders.Id != order.Id)
        //    {
        //        if(_context.AppOrders.Any(x => x.Id == AppOrders.Id))
        //            throw new AppException(AppOrders.Id);
        //    }
        //    order.Id = AppOrders.Id;
        //    //order.Meal = AppOrders.Meal;
        //    //order.Price = AppOrders.Price;

        //}

        public void Delete(int id)
        {
            var order = _context.Orders.Find(id);
            if (order != null)
            {
                _context.Orders.Remove(order);
                _context.SaveChanges();
            }
        }


        //public IEnumerable<Order> GetOrders()
        //{
        //    return context.Orders.Where(o => o.UserId == AppUser.Id.Name);
        //}
        //public Entities.Order GetOrder(int id)
        //{
        //    Order order = context.Orders.Include("OrderDetails.Meal")
        //        .First(o => o.Id == id && o.UserId == AppUser.Id.Name);


        //    return new Entities.Order()
        //    {
        //        Details = from d in order.OrderDetails
        //                  select new Entities.Order.Detail()
        //                  {
        //                      Id = d.Meal.Id,
        //                      Meal = d.Meal.Name,
        //                      User = d.Meal.User,
        //                      DeliveryCosts = d.DeliveryCosts,
        //                      TotalAmount = d.TotalAmount

        //                  }
        //    };
        //}
    }
}

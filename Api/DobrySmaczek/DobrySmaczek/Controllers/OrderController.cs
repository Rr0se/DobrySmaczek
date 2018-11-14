using DobrySmaczek.Entities;

namespace DobrySmaczek.Controllers
{
    public class OrderController
    {
        private readonly DataBaseContext context;
        public OrderController(DataBaseContext context)
        {
            this.context = context;
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

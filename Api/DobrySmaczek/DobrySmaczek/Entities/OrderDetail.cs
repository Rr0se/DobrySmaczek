using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DobrySmaczek.Entities
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public double DeliveryCosts { get; set; }
        public double TotalAmount { get; set; }

        public List<Meal> Meal { get; set; }
        public Order Order { get; set; }
    }
}

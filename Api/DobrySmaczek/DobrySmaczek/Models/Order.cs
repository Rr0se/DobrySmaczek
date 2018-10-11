using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DobrySmaczek.Models
{
    public class Order
    {
        public class Detail
        {
            public int Id { get; set; }
            public List<Meal> Meal { get; set; }
            public int UserId { get; set; }
            public double DeliveryCosts { get; set; }
            public double TotalAmount { get; set; }
        }

        public IEnumerable<Detail> Details { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DobrySmaczek.Entities
{
    public class AppOrder
    {
        public class Detail
        {
            public int Id { get; set; }
            public string Meal { get; set; }
            public decimal Price { get; set; }

        }
        public IEnumerable<Detail> Details { get; set; }
    }
}

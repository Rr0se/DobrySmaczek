using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DobrySmaczek.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }
        public double EstimatedDeliveryTime { get; set; }
        public double MinOrderAmount { get; set; }
        public double DeliveryCosts { get; set; }

        
        public List<Menu> Menu { get; set; }
        public InfoOfRestaurant InfoOfRestaurants { get; set; }
        public List<Reviews> Reviews { get; set; }

    }
}

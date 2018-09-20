using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DobrySmaczek.Models
{
    public class RestaurantProfile
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }
        public double EstimatedDeliveryTime { get; set; }
        public double MinOrderAmount { get; set; }
        public double DeliveryCosts { get; set; }

        public List<TypeOfFood> TypeOfFoods { get; set; }
        public List<Menu> Menu { get; set; }
        public List<InfoOfRestaurant> InfoOfRestaurants { get; set; }
        public List<Reviews> Reviews { get; set; }

    }
}

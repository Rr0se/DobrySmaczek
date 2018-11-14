using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace DobrySmaczek.Entities
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }
        public double EstimatedDeliveryTime { get; set; }
        public double MinOrderAmount { get; set; }
        public double DeliveryCosts { get; set; }

        public double Long { get; set; }
        public double Lat { get; set; }
        public double Radius { get; set; }


        public Menu Menu { get; set; }
        public InfoOfRestaurant InfoOfRestaurants { get; set; }
        public List<Review> Reviews { get; set; }

        public ICollection<RestaurantCategoryFood> RestaurantCategoryFoods { get; set; }
        //public ICollection<RestaurantInfoOfRestaurant> RestaurantInfoOfRestaurants { get; set; }
        //public ICollection<RestaurantMenu> RestaurantMenus { get; set; }

    }
}

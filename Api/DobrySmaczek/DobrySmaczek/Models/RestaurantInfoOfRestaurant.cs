using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DobrySmaczek.Models
{
    public class RestaurantInfoOfRestaurant
    {
        public int Id { get; set; }

        public int RestaurantId { get; set; }
        public int InfoOfRestaurantId { get; set; }

        public Restaurant Restaurant { get; set; }
        public InfoOfRestaurant InfoOfRestaurant { get; set; }

    }
}

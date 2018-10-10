using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DobrySmaczek.Models
{
    public class RestaurantReview
    {
        public int Id { get; set; }

        public int RestaurantId { get; set; }
        public int ReviewId { get; set; }

        public List<Restaurant> Restaurants { get; set; }
        

    }
}

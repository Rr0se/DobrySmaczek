using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DobrySmaczek.Models
{
    public class Restaurants
    {
        public Guid Id { get; set; }
        public List<RestaurantProfile> RestaurantProfiles { get; set; }
        public List<TypeOfFood> TypeOfFoods { get; set; }

    }
}

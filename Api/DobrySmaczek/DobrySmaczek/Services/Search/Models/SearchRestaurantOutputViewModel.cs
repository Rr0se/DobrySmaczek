using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DobrySmaczek.Services.Search.Models
{
    public class SearchRestaurantOutputViewModel
    {
        public List<RestaurantListViewModel> Restaurants { get; set; }
    }

    public class RestaurantListViewModel
    {
        public string Name { get; set; }
    }
}

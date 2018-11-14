using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DobrySmaczek.Services.Search.Models;
using DobrySmaczek.Services.User;

namespace DobrySmaczek.Services.Search
{
    public interface ISearchService
    {
        GlobalServiceModel<SearchRestaurantOutputViewModel> SearchRestaurant(double lat, double lon);
    }
}

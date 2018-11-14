using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DobrySmaczek.Entities;
using DobrySmaczek.Services.Search.Models;
using DobrySmaczek.Services.User;

namespace DobrySmaczek.Services.Search
{
    public class SearchService: ISearchService
    {
        private readonly DataBaseContext _context;

        public SearchService(DataBaseContext context)
        {
            _context = context;
        }

        public GlobalServiceModel<SearchRestaurantOutputViewModel> SearchRestaurant(double lat, double lon)
        {
            var allRestaurants = _context.Restaurants.ToList();

            var foundRestaurants = new List<RestaurantListViewModel>();
            foreach (var restaurant in allRestaurants)
            {
                var distance = DistanceInKmBetweenEarthCoordinates(lat, lon, restaurant.Lat, restaurant.Long);
                if(distance <= restaurant.Radius)
                    foundRestaurants.Add(new RestaurantListViewModel
                    {
                        Name = restaurant.Name
                    });
            }

            return new GlobalServiceModel<SearchRestaurantOutputViewModel>
            {
                ServiceResponse = ServiceResponseEnum.Ok,
                Response = new SearchRestaurantOutputViewModel
                {
                    Restaurants = foundRestaurants
                }           
            };
        }

        private double DegreesToRadians(double degrees)
        {
            return degrees * Math.PI / 180;
        }

        private double DistanceInKmBetweenEarthCoordinates(double lat1, double lon1, double lat2, double lon2)
        {
            var earthRadiusKm = 6371;

            var dLat = DegreesToRadians(lat2 - lat1);
            var dLon = DegreesToRadians(lon2 - lon1);

            lat1 = DegreesToRadians(lat1);
            lat2 = DegreesToRadians(lat2);

            var a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                    Math.Sin(dLon / 2) * Math.Sin(dLon / 2) * Math.Cos(lat1) * Math.Cos(lat2);
            var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            return earthRadiusKm * c;
        }
    }
}

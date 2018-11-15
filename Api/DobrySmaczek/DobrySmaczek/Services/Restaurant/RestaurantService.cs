using DobrySmaczek.Entities;
using DobrySmaczek.Services.Restaurant.Models;
using DobrySmaczek.Services.User;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DobrySmaczek.Services.Restaurant
{
    public class RestaurantService : IRestaurantService
    {
        private readonly DataBaseContext _context;

        public RestaurantService(DataBaseContext context)
        {
            _context = context;
        }
        
        public GlobalServiceModel<List<CategoryListViewModel>> GetCategories(int restaurantId)
        {
            var restaurant = _context.Restaurants.Include(r => r.Menu).ThenInclude(m => m.Meals).FirstOrDefault(r => r.Id == restaurantId);
            if(restaurant == null)
                return new GlobalServiceModel<List<CategoryListViewModel>> { ServiceResponse = ServiceResponseEnum.Failed };

            var categories = restaurant.Menu.Meals.Select(m => m.TypeOfFood).Distinct();

            var output = categories.Select(c => new CategoryListViewModel {Id = c.Id, Name = c.Name}).ToList();

            return new GlobalServiceModel<List<CategoryListViewModel>> { ServiceResponse = ServiceResponseEnum.Ok, Response = output };
        }

        public GlobalServiceModel<InfoOutputViewModel> GetInfo(int restaurantId)
        {
            var restaurant = _context.Restaurants.Include(r => r.OpeningHours)
                .FirstOrDefault(r => r.Id == restaurantId);
            if(restaurant == null)
                return new GlobalServiceModel<InfoOutputViewModel> { ServiceResponse = ServiceResponseEnum.Failed };

            var opening = restaurant.OpeningHours.Select(o =>
                new OpeningViewModel
                {
                    DayOfWeek = o.DayOfWeek, Open = o.Open, Close = o.Close,
                    IsCurrent = o.DayOfWeek == DateTime.Now.DayOfWeek
                }).ToList();

            var location = new LocationViewModel
            {
                Address = restaurant.Address,
                Lat = restaurant.Lat,
                Lon = restaurant.Long
            };

            var output = new InfoOutputViewModel
            {
                OpeningViewModel = opening,
                LocationViewModel = location,
                DeliveryCosts = restaurant.DeliveryCosts,
                EstimatedDeliveryTime = restaurant.EstimatedDeliveryTime,
                MinOrderAmount = restaurant.MinOrderAmount
            };

            return new GlobalServiceModel<InfoOutputViewModel> { ServiceResponse = ServiceResponseEnum.Ok, Response = output };
        }

        public GlobalServiceModel<List<MealViewModel>> GetMenu(int restaurantId, int? typeOfFoodId)
        {
            var restaurant = _context.Restaurants.Include(r => r.Menu).ThenInclude(m => m.Meals)
                    .FirstOrDefault(r => r.Id == restaurantId);
            if(restaurant == null)
                return new GlobalServiceModel<List<MealViewModel>> { ServiceResponse = ServiceResponseEnum.Failed};

            var output = restaurant.Menu.Meals.Select(meal =>
                new MealViewModel
                {
                    Id = meal.Id, Name = meal.Name, Components = meal.Components, Price = meal.Price,
                    TypeOfFood = meal.TypeOfFood.ToString()
                }).ToList();
            return new GlobalServiceModel<List<MealViewModel>> { ServiceResponse = ServiceResponseEnum.Ok, Response = output };
        }

        public GlobalServiceModel<List<ReviewOutputViewModel>> GetReview(int restaurantId)
        {
            var restaurant = _context.Restaurants.Include(r => r.Reviews).FirstOrDefault(r => r.Id == restaurantId);

            if(restaurant == null)
                return new GlobalServiceModel<List<ReviewOutputViewModel>> { ServiceResponse = ServiceResponseEnum.Failed };

            var output = restaurant.Reviews.Select(review => new ReviewOutputViewModel
            {
                RatingDelivery = review.RatingDelivery,
                RatingFood = review.RatingFood,
                Review = review.TextReview
            }).ToList();

            return new GlobalServiceModel<List<ReviewOutputViewModel>> { ServiceResponse = ServiceResponseEnum.Ok, Response = output };
        }
        

    }
}

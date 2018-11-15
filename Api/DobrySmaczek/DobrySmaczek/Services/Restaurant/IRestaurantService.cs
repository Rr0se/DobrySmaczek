using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DobrySmaczek.Entities;
using DobrySmaczek.Services.Restaurant.Models;
using DobrySmaczek.Services.User;

namespace DobrySmaczek.Services.Restaurant
{
    public interface IRestaurantService
    {
        GlobalServiceModel<List<MealViewModel>> GetMenu(int restaurantId, int? typeOfFoodId);
        GlobalServiceModel<List<CategoryListViewModel>> GetCategories(int restaurantId);
        GlobalServiceModel<List<ReviewOutputViewModel>> GetReview(int restaurantId);
        GlobalServiceModel<InfoOutputViewModel> GetInfo(int restaurantId);
       
    }
}

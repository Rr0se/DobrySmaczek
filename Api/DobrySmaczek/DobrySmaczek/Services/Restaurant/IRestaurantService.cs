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
        GlobalServiceModel<MenuOutputViewModel> GetMenu(int RestaurantId, int MenuId);
        GlobalServiceModel<CategoryOutputViewModel> GetCategory(int RestaurantId, int CategoryFoodId);
        GlobalServiceModel<ReviewOutputViewModel> GetReview(int RestaurantId, int ReviewId);
        GlobalServiceModel<InfoOutputViewModel> GetInfo(int RestaurantId, int InfoOfRestaurantId);
       
    }
}

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
        
        public GlobalServiceModel<CategoryOutputViewModel> GetCategory(int restaurantId)
        {
            return _context.CategoryFoods.Include(x => x.CategoryOutputViewModel).ThenInclude(z => z.Restaurant)
                .Where(b => b.CategoryOutputViewModel.Any(x => x.RestaurantId == restaurantId)).Orderby().ToListy();
        }

        public GlobalServiceModel<InfoOutputViewModel> GetInfo(int RestaurantId, int InfoOfRestaurantId)
        {
            throw new NotImplementedException();
        }

        public GlobalServiceModel<MenuOutputViewModel> GetMenu(int RestaurantId, int MenuId)
        {
            throw new NotImplementedException();
        }

        public GlobalServiceModel<ReviewOutputViewModel> GetReview(int RestaurantId, int ReviewId)
        {
            throw new NotImplementedException();
        }
        

    }
}

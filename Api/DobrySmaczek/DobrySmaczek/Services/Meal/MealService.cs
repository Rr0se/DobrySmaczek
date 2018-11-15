using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DobrySmaczek.Entities;
using DobrySmaczek.Services.Meal.Models;
using DobrySmaczek.Services.User;
using Microsoft.EntityFrameworkCore;

namespace DobrySmaczek.Services.Meal
{
    public class MealService: IMealService
    {
        private readonly DataBaseContext _context;

        public MealService(DataBaseContext context)
        {
            _context = context;
        }

        public GlobalServiceModel<MealAdditionsOutputViewModel> GetMealAdditions(int mealId)
        {
            var meal = _context.Meals.Include(m => m.MealAdditions).ThenInclude(ma => ma.Addition)
                .FirstOrDefault(m => m.Id == mealId);
            if(meal == null)
                return new GlobalServiceModel<MealAdditionsOutputViewModel> { ServiceResponse = ServiceResponseEnum.Failed };

            return new GlobalServiceModel<MealAdditionsOutputViewModel>
            {
                ServiceResponse = ServiceResponseEnum.Ok,
                Response = new MealAdditionsOutputViewModel
                {
                    Sauces = meal.MealAdditions.Where(ma => ma.Addition.AdditionType == AdditionType.Sauce).Select(ma =>
                        new SingleAdditionOutputViewModel
                            {Id = ma.Addition.Id, Name = ma.Addition.Name, Price = ma.Addition.Price}).ToList(),
                    Additions = meal.MealAdditions.Where(ma => ma.Addition.AdditionType == AdditionType.Addition)
                        .Select(ma =>
                            new SingleAdditionOutputViewModel
                                {Id = ma.Addition.Id, Name = ma.Addition.Name, Price = ma.Addition.Price}).ToList(),
                    OtherAdditions = meal.MealAdditions
                        .Where(ma => ma.Addition.AdditionType == AdditionType.OtherAddition).Select(ma =>
                            new SingleAdditionOutputViewModel
                                {Id = ma.Addition.Id, Name = ma.Addition.Name, Price = ma.Addition.Price}).ToList(),
                    Drinks = meal.MealAdditions.Where(ma => ma.Addition.AdditionType == AdditionType.Drinks).Select(
                        ma =>
                            new SingleAdditionOutputViewModel
                                {Id = ma.Addition.Id, Name = ma.Addition.Name, Price = ma.Addition.Price}).ToList(),
                }
            };
        }
    }
}

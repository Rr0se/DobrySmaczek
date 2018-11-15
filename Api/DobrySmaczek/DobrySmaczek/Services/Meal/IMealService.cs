using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DobrySmaczek.Services.Meal.Models;
using DobrySmaczek.Services.User;

namespace DobrySmaczek.Services.Meal
{
    public interface IMealService
    {
        GlobalServiceModel<MealAdditionsOutputViewModel> GetMealAdditions(int mealId);
    }
}

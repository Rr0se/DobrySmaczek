using DobrySmaczek.Entities;
using DobrySmaczek.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace DobrySmaczek.Controllers
{
    public class MealController : Controller
    {
        private readonly DataBaseContext context;
        public MealController(DataBaseContext context)
        {
            this.context = context;
        }
        private IQueryable<Models.Meal> MapMeals()
        {
            return from m in context.Meals
                   select new Models.Meal()
                   { Id = m.Id, Name = m.Name, Price = m.Price, Components = m.Components };
        }
        public IEnumerable<Models.Meal> GetMeals()
        {
            return MapMeals().AsEnumerable();
        }
        public Models.Meal GetMeal(int id)
        {
            var meal = (from p in MapMeals()
                           where p.Id == 1
                           select p).FirstOrDefault();
            
            return meal;
        }
        protected override void Dispose(bool disposing)
        {
            context.Dispose();
            base.Dispose(disposing);
        }


    }
}

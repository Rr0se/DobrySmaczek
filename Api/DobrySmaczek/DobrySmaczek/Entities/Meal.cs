using DobrySmaczek.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DobrySmaczek.Entities
{
    public class Meal
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Components { get; set; }
        public decimal Price { get; set; }
        public TypeOfFood TypeOfFood { get; set; }

        //public ICollection<MenuMeal> MenuMeals { get; set; }
    }
}

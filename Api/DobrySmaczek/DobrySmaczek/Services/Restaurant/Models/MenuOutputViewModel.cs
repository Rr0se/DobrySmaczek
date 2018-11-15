using DobrySmaczek.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DobrySmaczek.Services.Restaurant.Models
{
    public class MealViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Components { get; set; }
        public decimal Price { get; set; }
        public string TypeOfFood { get; set; }
    }
}

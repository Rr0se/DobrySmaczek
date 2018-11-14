using DobrySmaczek.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DobrySmaczek.Services.Restaurant.Models
{
    public class MenuOutputViewModel
    {
        public int Id { get; set; }
        public List<MenuListViewModel> Menus { get; set; }
    }

    public class MenuListViewModel
    {
        public int Id { get; set; }
        public List<Meal> Meals { get; set; }
    }
}

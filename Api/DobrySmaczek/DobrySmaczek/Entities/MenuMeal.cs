using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DobrySmaczek.Entities
{
    public class MenuMeal
    {
        public int Id { get; set; }

        public int MenuId { get; set; }
        public int MealId { get; set; }

        public Menu Menu { get; set; }
        public Meal Meal { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DobrySmaczek.Services.Meal.Models
{
    public class MealAdditionsOutputViewModel
    {
        public IList<SingleAdditionOutputViewModel> Sauces { get; set; }
        public IList<SingleAdditionOutputViewModel> Additions { get; set; }
        public IList<SingleAdditionOutputViewModel> OtherAdditions { get; set; }
        public IList<SingleAdditionOutputViewModel> Drinks { get; set; }
    }
    public class SingleAdditionOutputViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}

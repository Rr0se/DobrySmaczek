using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DobrySmaczek.Entities
{
    public class Addition
    {
        public int Id { get; set; }
        public AdditionType AdditionType { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Restaurant Restaurant { get; set; }
        public ICollection<MealAddition> Meal { get; set; }
    }

    public enum AdditionType
    {
        Sauce,
        Addition,
        OtherAddition,
        Drinks
    }
}

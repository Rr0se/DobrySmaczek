using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DobrySmaczek.Entities
{
    public class MealAddition
    {
        public int Id { get; set; }
        public int MealId { get; set; }
        public int AdditionId { get; set; }
        public Meal Meal { get; set; }
        public Addition Addition { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DobrySmaczek.Entities
{
    public class CategoryFood
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<RestaurantCategoryFood> RestaurantCategoryFoods { get; set; }
    }
}

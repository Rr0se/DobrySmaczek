using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DobrySmaczek.Models
{
    public class RestaurantCategoryFood
    {
        public int Id { get; set; }

        public int RestaurantId { get; set; }
        public int CategoryFoodId { get; set; }

        public Restaurant Restaurant { get; set; }
        public CategoryFood CategoryFood { get; set; }


    }
}

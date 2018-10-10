using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DobrySmaczek.Models
{
    public class RestaurantMenu
    {
        public int Id { get; set; }

        public int RestaurantId { get; set; }
        public int MenuId { get; set; }

        public Restaurant Restaurant { get; set; }
        public Menu Menu { get; set; }

    }
}

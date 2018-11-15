using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DobrySmaczek.Entities
{
    public class Menu
    {
        public int Id { get; set; }
        public List<Meal> Meals { get; set; }

        public Restaurant Restaurant { get; set; }

    }
}

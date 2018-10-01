using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DobrySmaczek.Models
{
    public class Menu
    {
        public int Id { get; set; }
        public List<Meal> Meals { get; set; }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DobrySmaczek.Entities
{
    public class MenuTypeOfFood
    {
        public int Id { get; set; }

        public int MenuId { get; set; }
        public int TypeOfFoodId { get; set; }

        public Menu Menu { get; set; }
        public TypeOfFood TypeOfFood { get; set; }

    }
}

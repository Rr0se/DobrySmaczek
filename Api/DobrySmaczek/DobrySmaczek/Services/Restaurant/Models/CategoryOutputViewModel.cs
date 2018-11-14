using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DobrySmaczek.Services.Restaurant.Models
{
    public class CategoryOutputViewModel
    {
        public int Id { get; set; }
        public List<CategoryListViewModel> Categories { get; set; }
    }

    public class CategoryListViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

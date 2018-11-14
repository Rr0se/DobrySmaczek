using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DobrySmaczek.Services.Restaurant.Models
{
    public class ReviewOutputViewModel
    {

        public int Id { get; set; }

        public List<ReviewListViewModel> MyProperty { get; set; }
    }

    public class ReviewListViewModel
    {
        public int Id { get; set; }

        public int RatingDelivery { get; set; }
        public int RatingFood { get; set; }
    }
}

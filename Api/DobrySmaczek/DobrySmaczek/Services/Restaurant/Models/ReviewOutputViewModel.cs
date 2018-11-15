using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DobrySmaczek.Services.Restaurant.Models
{
    public class ReviewOutputViewModel
    {
        public int RatingDelivery { get; set; }
        public int RatingFood { get; set; }
        public string Review { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DobrySmaczek.Entities
{
    public class Review
    {
        public int Id { get; set; }
        public int RatingDelivery { get; set; }
        public int RatingFood { get; set; }
        public int UserId { get; set; }

        public Restaurant Restaurant { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DobrySmaczek.Models
{
    public class Reviews
    {
        public Guid Id { get; set; }
        public int RatingDelivery { get; set; }
        public int RatingFood { get; set; }

    }
}

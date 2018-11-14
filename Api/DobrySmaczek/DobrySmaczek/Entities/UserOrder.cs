using DobrySmaczek.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DobrySmaczek.Entities
{
    public class UserOrder
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public int OrderId { get; set; }

        public AppUser User { get; set; }
        public Order Orders { get; set; }
    }
}

using DobrySmaczek.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DobrySmaczek.Models
{
    public class UserOrder
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public int OrderId { get; set; }

        public UserModel UserModel { get; set; }
        public AppOrder Orders { get; set; }
    }
}

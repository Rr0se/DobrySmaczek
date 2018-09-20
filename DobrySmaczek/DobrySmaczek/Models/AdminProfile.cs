using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DobrySmaczek.Models
{
    public class AdminProfile
    {
        public Guid Id { get; set; }

        public List<Users> Users { get; set; }
        public List<Restaurants> Restaurants { get; set; }

    }
}

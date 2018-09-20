using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DobrySmaczek.Models
{
    public class Users
    {
        public Guid Id { get; set; }
        public List<UserProfile> UserProfiles { get; set; }
    }
}

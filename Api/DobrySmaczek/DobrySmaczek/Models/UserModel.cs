using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DobrySmaczek.Models
{
    public class UserModel
    {
        
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string access_token { get; set; }
        public string Password { get; set; }
        public string ClaimsUser { get; set; }

        public UserType UserType { get; set; }
    }
    
    public enum UserType
    { 
        [Display(Name = "GlobalAdministrator")]
        GlobalAdministrator = 0,
        [Display(Name = "CompanyAdministrator")]
        CompanyAdministrator = 1,
        [Display(Name = "Użytkownik")]
        User = 2,
    }
}

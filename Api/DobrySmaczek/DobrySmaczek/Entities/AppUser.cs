using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DobrySmaczek.Entities
{
    public class AppUser
    {
        
        public int Id { get; set; }

        [Required(ErrorMessage = "Wpisz Imie")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Wpisz Nazwisko")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Wpisz Nick")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Wpisz Maila")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Wpisz Numer telefonu")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Wpisz Kod pocztowy")]
        public string PostCode { get; set; }

        [Required(ErrorMessage = "Wpisz Miasto")]
        public string City { get; set; }

        [Required(ErrorMessage = "Wpisz Ulicę")]
        public string Street { get; set; }

        [Required(ErrorMessage = "Wpisz Numer domu")]
        public string HouseNumber { get; set; }

        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        public string access_token { get; set; }

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

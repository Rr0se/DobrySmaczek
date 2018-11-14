using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using DobrySmaczek.Entities;

namespace DobrySmaczek.Services.User.Models
{
    public class UserInputViewModel
    {

        [Required(ErrorMessage = "Wpisz Imie")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Wpisz Nazwisko")]
        public string LastName { get; set; }

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

        public string Password { get; set; }



    }
}

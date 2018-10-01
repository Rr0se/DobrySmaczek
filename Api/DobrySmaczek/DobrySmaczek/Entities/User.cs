using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DobrySmaczek.Entities
{
    public class User
    {
        [Key]
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

        public Users Users { get; set; }

    }

    public enum Users { GlobalAdmin, CompanyAdmin, User }

}

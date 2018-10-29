using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DobrySmaczek.Services.Authentication.Models
{
    public class SetNewPassword
    {
        [Required]
        public string SecurityToken { get; set; }

        [Required(ErrorMessage = "To pole jest wymagane")]
        [MinLength(8, ErrorMessage = "Pole musi mieć długość minimum 8 znaków")]
        [DataType(DataType.Password)]
        [DisplayName("Nowe hasło")]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "To pole jest wymagane")]
        [MinLength(8, ErrorMessage = "Pole musi mieć długość minimum 8 znaków")]
        [DataType(DataType.Password)]
        [DisplayName("Powtórz hasło")]
        public string RepeatPassword { get; set; }

        public string Message { get; set; }
    }
}

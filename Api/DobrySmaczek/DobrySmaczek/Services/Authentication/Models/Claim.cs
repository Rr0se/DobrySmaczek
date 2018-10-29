using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DobrySmaczek.Services.Authentication.Models
{
    public class Claim
    {
        public int Id { get; set; }

        public ClaimType ClaimName { get; set; }
    }

    public enum ClaimType
    {
            [Display(Name = "Dodanie dokumentu")]
            AddingDocument = 0,
            [Display(Name = "Usuwanie dokumentu")]
            RemovingDocument = 1,
            [Display(Name = "Dodanie dokumentu do wysłania")]
            AddingDocumentToSent = 2,
            [Display(Name = "Edycja dokumentu")]
            EditionDocument = 3,
            [Display(Name = "Tworzenie puli dnia")]
            CreatingPoolDay = 4,
            [Display(Name = "Zamknięcie puli dnia")]
            ClosingPoolDay = 5,
            [Display(Name = "Generowanie puli dnia")]
            GeneratingPostRegister = 6,
            [Display(Name = "Weryfikacja dokumentu")]
            VerifyingDocument = 7
    }

     public enum TokenClaim
     {
            UserId,
            UserRole,
            IdentyficationGuid,
            UserClaim,
            IsOperator,
            UserRoleId
     }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Adres e-mail")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Nr. prawa jazdy")]
        public string DrivingLicense { get; set; }

        [Required]
        [MinLength(9, ErrorMessage = "Numer telefonu musi posiadac 9 znakow")]
        [MaxLength(9, ErrorMessage = "Numer telefonu musi posiadac 9 znakow")]
        [Display(Name = "Telefon")]
        public string PhoneNumber { get; set; }


    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }
}
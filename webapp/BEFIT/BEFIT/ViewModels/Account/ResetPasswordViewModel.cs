using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BEFIT.ViewModels.Account
{
    public class ResetPasswordViewModel
    {
        [Required(ErrorMessage = "Email je obavezno polje")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Šifra je obavezno polje")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage ="Šifra i potvrdi šifru moraju biti isti")]
        [Required(ErrorMessage = "Potvrdi šifru je obavezno polje")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
        public string Token { get; set; }

    }
}

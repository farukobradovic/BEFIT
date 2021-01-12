using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BEFIT.ViewModels.Account
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Ime je obavezno polje")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Šifra je obavezno polje")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name ="Zapamti Me")]
        public bool RememberMe { get; set; }

    }
}

using BEFIT.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BEFIT.ViewModels.Account
{
    public class SecurityViewModel
    {
        [Required(ErrorMessage = "Stara šifra je obavezno polje")]
        public string OldPassword { get; set; }
        [Required(ErrorMessage = "Nova šifra je obavezno polje")]
        public string NewPassword { get; set; }
        [Required(ErrorMessage = "Potvrdi šifru je obavezno polje")]
        [Compare("NewPassword", ErrorMessage = "Nova šifra i potvrdi šifru moraju biti iste.")]
        public string ConfirmPassword { get; set; }
        public string UserID { get; set; }
    }
}

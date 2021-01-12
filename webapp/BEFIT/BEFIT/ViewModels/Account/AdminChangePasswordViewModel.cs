using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BEFIT.ViewModels.Account
{
    public class AdminChangePasswordViewModel
    {
        [Required(ErrorMessage = "Šifra je obavezno polje")]
        public string NewPassword { get; set; }

    }
}

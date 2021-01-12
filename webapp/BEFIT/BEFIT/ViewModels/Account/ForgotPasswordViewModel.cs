using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BEFIT.ViewModels.Account
{
    public class ForgotPasswordViewModel
    {
        [Required(ErrorMessage = "Email je obavezno polje")]
        [EmailAddress]
        public string Email { get; set; }

    }
}

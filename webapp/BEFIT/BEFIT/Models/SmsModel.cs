using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BEFIT.Models
{
    public class SmsModel
    {
        [Required(ErrorMessage ="Broj primaoca je neophodan!",AllowEmptyStrings =false)]
        [Phone]
        [Display(Name ="Primaoc")]
        public string To { get; set; }
        [Required(ErrorMessage = "Broj posiljaoca je neophodan!", AllowEmptyStrings = false)]
        [Phone]
        [Display(Name = "Posiljaoc")]
        public string From { get; set; }
        [Required(ErrorMessage = "Niste unijeli tekst poruke!", AllowEmptyStrings = false)]
        [Display(Name = "Tekst poruke")]

        public string Text { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BEFIT.ViewModels.Administration
{
    public class CreateRoleViewModel
    {
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Naziv uloge mora da ima minimalno 3 karaktera")]
        [Required(ErrorMessage = "Naziv uloge je obavezno polje")]
        public string RoleName { get; set; }
        [StringLength(200, MinimumLength = 10, ErrorMessage = "Opis uloge mora da ima minimalno 10 karaktera")]
        [Required(ErrorMessage = "Opis uloge je obavezno polje")]
        public string Description { get; set; }

    }
}

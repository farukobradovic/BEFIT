using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BEFIT.Models
{
    public class Role : IdentityRole
    {
        public DateTime DateCreated { get; set; }
        [Required(ErrorMessage = "Opis je obavezno polje")]
        public string Description { get; set; }

    }
}

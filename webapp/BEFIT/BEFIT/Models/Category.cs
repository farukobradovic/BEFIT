using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BEFIT.Models
{
    public class Category
    {
        public int CategoryID { get; set; }

        [Required(ErrorMessage ="Morate unijeti kategoriju !")]
        [Display(Name="Naziv kategorije")]
        public string CategoryName { get; set; }
    }
}

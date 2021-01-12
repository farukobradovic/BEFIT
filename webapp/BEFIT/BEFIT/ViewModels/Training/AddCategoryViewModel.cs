using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BEFIT.ViewModels.Training
{
    public class AddCategoryViewModel
    {
        [Required(ErrorMessage = "Naziv kategorije je obavezno polje")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Opis je obavezno polje")]
        public string Description { get; set; }

    }
}

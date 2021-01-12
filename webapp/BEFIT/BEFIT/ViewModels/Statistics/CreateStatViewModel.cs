using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BEFIT.ViewModels.Statistics
{
    public class CreateStatViewModel
    {
        [Required(ErrorMessage = "Visina je obavezno polje")]
        public int Height { get; set; }
        [Required(ErrorMessage = "Kilaža je obavezno polje")]
        public double WeightInKilos { get; set; }
    }
}

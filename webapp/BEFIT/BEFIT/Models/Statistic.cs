using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BEFIT.Models
{
    public class Statistic
    {
        public int StatisticID { get; set; }
        [Required(ErrorMessage = "Visina je obavezno polje")]

        public double Height { get; set; }
        [Required(ErrorMessage = "Tezina je obavezno polje")]
        public double WeightInKilos { get; set; }

        public DateTime DateCalculated { get; set; }

        public User User { get; set; }

        public string UserID { get; set; }
        public double CalculatedBMI { get; set; }
        public double AverageBMI { get; set; }

    }
}

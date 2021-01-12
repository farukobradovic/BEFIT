using BEFIT.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BEFIT.ViewModels.Training
{
    public class CreateTrainingViewModel
    {
        [Required(ErrorMessage = "Datum početka je obavezno polje")]
        public DateTime TrainingFrom  { get; set; }
        [Required(ErrorMessage = "Datum završetka je obavezno polje")]
      
        public DateTime TrainingTill { get; set; }
        public string TrainingCategory { get; set; }
        public List<TrainingType> TrainingCategories { get; set; }
        public string NameLastname { get; set; }

        //public List<TrainingUser> TrainingUsers { get; set; }
        public List<int> TrainingIDs { get; set; }
      
    }
}

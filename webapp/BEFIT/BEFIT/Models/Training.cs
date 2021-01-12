using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BEFIT.Models
{
    public class Training
    {
        public int TrainingID { get; set; }
        [Required(ErrorMessage = "Vrijeme treniga je obavezno polje")]
        public DateTime TrainingFrom { get; set; }
        [Required(ErrorMessage = "Vrijeme treninga je obavezno polje")]
        public DateTime TrainingTill { get; set; }

        public TrainingType TrainingType { get; set; }
        public int TrainingTypeID { get; set; }
        [ForeignKey("UserID")]
        public User User { get; set; }
        public string UserID { get; set; }

        [ForeignKey("AuthorID")]
        public User Author { get; set; }
        public string AuthorID { get; set; }
    }
}

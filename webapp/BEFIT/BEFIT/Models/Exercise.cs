using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BEFIT.Models
{
    public class Exercise
    {
        public int ExerciseID { get; set; }

        [Required(ErrorMessage = "Potrebno je unijeti naziv vjezbe!")]

        public string ExerciseName { get; set; }
        [Required(ErrorMessage = "Potrebno je unijeti opis vjezbe!")]

        public string Description { get; set; }
        [Required(ErrorMessage = "Potrebno je unijeti tezinu vjezbe!")]

        public int  Difficulty { get; set; }
        [ForeignKey("UserID")]
        public User User { get; set; }
        public string UserID { get; set; }
        [ForeignKey("CategoryID")]
        public Category Category { get; set; }
        public int CategoryID { get; set; }

        public string PhotoPath { get; set; }
    }
}

using BEFIT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BEFIT.ViewModels.Exercise
{
    public class DisplayViewModel
    {

        public int ID { get; set; }
        public string ExerciseName { get; set; }
        public string ExerciseDescription { get; set; }
        public int Difficulty { get; set; }

        public string CategoryName { get; set; }
        public string Photo { get; set; }


    }
}

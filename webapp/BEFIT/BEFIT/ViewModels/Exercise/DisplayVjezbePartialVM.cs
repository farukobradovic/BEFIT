using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BEFIT.ViewModels.Exercise
{
    public class DisplayVjezbePartialVM
    {
        public int CategoryId { get; set; }

        public List<Rows> rows { get; set; }

        public class Rows
        {
            public int ExerciseId { get; set; }
            public string ExerciseName { get; set; }
            public string Description { get; set; }
            public string PhotoPath { get; set; }
            public string CategoryName { get; set; }
        }
    }
}

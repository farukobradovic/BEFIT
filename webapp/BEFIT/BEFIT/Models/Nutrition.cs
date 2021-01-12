using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BEFIT.Models
{
    public class Nutrition
    {
        public int NutritionID { get; set; }
        [ForeignKey("UserID")]
        public User User { get; set; }
        public string UserID { get; set; }
        [ForeignKey("AuthorID")]
        public User Author { get; set; }
        public string AuthorID { get; set; }

        public DateTime Date { get; set; }
        public string Description { get; set; }
        //public string Author { get; set; }
        public string FilePath { get; set; }

    }
}

using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BEFIT.ViewModels.Nutrition
{
    public class CreateNutritionViewModel
    {
        public string Name { get; set; }
        [StringLength(1000, MinimumLength = 20, ErrorMessage = "Plan ishrane mora da ima minimalno 20 karaktera")]
        [Required(ErrorMessage = "Plan ishrane je obavezno polje")]
        public string NutritionText { get; set; }
        public string Author { get; set; }

        public int  NutritionID { get; set; }
        public string UserID { get; set; }
        public string AuthorID { get; set; }
        public bool Edit { get; set; }
        public IFormFile File { get; set; }
    }
}

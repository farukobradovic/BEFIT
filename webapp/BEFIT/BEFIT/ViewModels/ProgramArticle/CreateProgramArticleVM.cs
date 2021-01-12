using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BEFIT.ViewModels.ProgramArticle
{
    public class CreateProgramArticleVM
    {
        public int Id { get; set; }
        [Display(Name= "Naziv članka")]
        [Required]
        public string Name { get; set; }
        [Display(Name="Sadržaj članka")]
        public string Description { get; set; }

        public string Date { get; set; }

        public IFormFile Photo { get; set; }
    }
}

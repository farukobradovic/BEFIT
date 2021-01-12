using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using BEFIT.Data;
using BEFIT.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BEFIT.ViewModels.Exercise
{
    public class KreirajVjezbuVM
    {
        public int ID { get; set; }

        public int CategoryID { get; set; }
        [Required(ErrorMessage = "Naziv vjezbe je obavezno polje!")]
        [Display(Name = "Naziv vjezbe")]
        public string ExerciseName { get; set; }
        [Required(ErrorMessage = "Vjezba ne moze da bude dostupna bez opisa!")]
        [Display(Name="Opis vjezbe")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Nivo tezine vjezbe mora biti unesen!")]
        [Display(Name="Nivo tezine")]
        public int Difficulty { get; set; }

        public List<SelectListItem> Category { get; set; }

        [Display(Name ="Fotografija")]
        public IFormFile Photo { get; set; }
    }
}

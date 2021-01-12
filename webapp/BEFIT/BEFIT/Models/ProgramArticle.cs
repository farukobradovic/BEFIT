using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BEFIT.Models
{
    public class ProgramArticle
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Naziv programa je neophodan!", AllowEmptyStrings = false)]
        public string ProgramName { get; set; }

        [Required(ErrorMessage = "Opis programa je neophodan!", AllowEmptyStrings = false)]

        public string ProgramDescription { get; set; }

        public string PhotoPath { get; set; }

        public string CreatedDate { get; set; }
        
     

    }
}

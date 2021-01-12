using BEFIT.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BEFIT.ViewModels.Message
{
    public class CreateMessageViewModel
    {
        [Required(ErrorMessage = "Naslov je obavezno polje")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Opis je obavezno polje")]
        public string Description { get; set; }
        public string Type { get; set; }
        public List<string> TypeNames { get; set; }
        public User User { get; set; }
    }
}

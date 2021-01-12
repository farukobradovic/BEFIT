using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BEFIT.ViewModels.MessageType
{
    public class CreateMessageTypeViewModel
    {
        [Required(ErrorMessage = "Naslov je obavezno polje")]
        public string Name { get; set; }
        
    }
}

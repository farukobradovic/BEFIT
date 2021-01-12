using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BEFIT.Models
{
    public class Message
    {
        public int ID { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateResolved { get; set; }
        public int TypeID { get; set; }
        public MessageType Type { get; set; }
        [Required(ErrorMessage = "Naslov je obavezno polje")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Opis je obavezno polje")]
        public string Description { get; set; }
        public User User { get; set; }
        public string UserID { get; set; }
        public bool Resolved { get; set; }


    }
}

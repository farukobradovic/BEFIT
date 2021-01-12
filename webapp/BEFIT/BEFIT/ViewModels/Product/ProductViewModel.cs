using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BEFIT.ViewModels.Product
{
    public class ProductViewModel
    {
        [Required(ErrorMessage ="Naziv proizvoda je obavezno polje")]
        [StringLength(25,ErrorMessage ="Naziv proizvoda ne bi trebao imati vise od 25 karaktera")]
        public string Naziv { get; set; }

        [Required(ErrorMessage = "Datum proizvoda je obavezno polje")]
        public DateTime ProductDate { get; set; }

        [Required(ErrorMessage ="Rok trajanja proizvoda je obavezno polje")]
        public DateTime ExpirationDate { get; set; }

        [Required(ErrorMessage ="Proizvod ne moze stajati bez cijene")]
        public int Price { get; set; }
    }
}

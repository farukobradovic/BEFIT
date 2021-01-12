using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BEFIT.Models
{
    public class Product
    {
        public int ProductID { get; set; }

        [Required(ErrorMessage="Naziv proizvoda je obavezno polje!")]
        public string Naziv { get; set; }
        [Required(ErrorMessage="Datum narudzbe je obavezno polje!")]

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy H:mm}")]
        [Display(Name = "Datum narudzbe")]
        public DateTime OrderDate { get; set; }
        [Required(ErrorMessage = "Datum trajanja je obavezno polje!")]

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy H:mm}")]
        [Display(Name = "Datum trajanja")]
        public DateTime ExpirationDate { get; set; }

        [Required(ErrorMessage="Cijena je obavezno polje!")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
    }
}

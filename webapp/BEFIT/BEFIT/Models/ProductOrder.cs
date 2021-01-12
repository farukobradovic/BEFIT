using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BEFIT.Models
{
    public class ProductOrder
    {

        public int ProductOrderID { get; set; }

        public Product Product { get; set; }
        public int ProductID { get; set; }
        [Required(ErrorMessage = "Datum narudzbe je obavezno polje!")]

        public DateTime OrderDate { get; set; }

        public DateTime OrderCancellation { get; set; }

        public User User { get; set; }

        public string UserID { get; set; }
    }
}

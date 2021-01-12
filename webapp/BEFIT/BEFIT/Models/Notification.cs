using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BEFIT.Models
{
    public class Notification
    {

        public int NotificationID { get; set; }

        [Required(ErrorMessage ="Naziv obavijesti nije unesen")]
        [StringLength(50)]
        [Display(Name ="Naziv obavijesti")]
        public string NotificationName { get; set; }


        [Required(ErrorMessage = "Niste unijeli datum objave ")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy H:mm}")]
        [Display(Name = "Datum obavijesti")]

        public DateTime DateOfPublishing { get; set; }

        [Display(Name ="Sadrzaj obavijesti")]
        [Required(ErrorMessage = "Obavijest se ne moze objaviti bez sadrzaja")]
        public string NotificationContent { get; set; }


    }
}

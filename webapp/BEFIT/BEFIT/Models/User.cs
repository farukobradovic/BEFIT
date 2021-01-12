using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BEFIT.Models
{
    public class User : IdentityUser
    {
        [Required(ErrorMessage = "Ime je obavezno polje")]
        public string Firstname { get; set; }
        [Required(ErrorMessage = "Prezime je obavezno polje")]
        public string Lastname { get; set; }

        public DateTime? DateOfRegister { get; set; }
        public string Certificate { get; set; }
        public DateTime? DateOfGettingCertificate { get; set; }
        public bool Student { get; set; }
        [Required(ErrorMessage = "Cijena clanarine je neophodna!")]

        public int MembershipPrice { get; set; }
        [Required(ErrorMessage = "Datum rodjena je obavezno polje")]
        public DateTime? Birthdate { get; set; }

        public DateTime? DateOfMembershipPayment { get; set; }

        public Notification Notification { get; set; }

        //public int NotificationID { get; set; }

        public Gender Gender { get; set; }
        //public int GenderId { get; set; }


    }
}

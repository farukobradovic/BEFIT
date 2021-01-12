using BEFIT.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BEFIT.ViewModels.Register
{
    public class RegisterViewModel
    {
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Ime mora da ima minimalno 3 karaktera")]
        [Required(ErrorMessage = "Ime je obavezno polje")]
        [Display(Name="Ime")]
        public string Firstname { get; set; }
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Prezime mora da ima minimalno 3 karaktera")]
        [Required(ErrorMessage = "Prezime je obavezno polje")]
        [Display(Name = "Prezime")]
        public string LastName { get; set; }
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Datum rođenja je obavezno polje")]
        [Display(Name = "Datum rođenja")]
        //[DataType(DataType.Date)]
        public DateTime? Birthdate { get; set; }
        public bool Student { get; set; }
        [RegularExpression(@"\(?\d{3}\)?-? *\d{3}-? *-?\d{3}",
        ErrorMessage = @"Broj telefona mora biti u formatu 06X-222-222")]
        [Required(ErrorMessage = "Broj telefona je obavezno polje")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Email je obavezno polje")]
        [EmailAddress(ErrorMessage = "Email adresa nije validna")]
        public string Email { get; set; }
        public string Certificate { get; set; }
        [DataType(DataType.Date)]
        public DateTime? DateOfGettingCertificate { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Šifra je obavezno polje")]
        [Display(Name = "Šifra")]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Potvrdi šifru je obavezno polje")]
        [Display(Name="Potvrdi šifru")]
        [Compare("Password", ErrorMessage ="Šifre se ne podudaraju.")]
        public string ConfirmPassword { get; set; }
        [DataType(DataType.Date)]
        public DateTime? DateOfMembershipPayment { get; set; }
        public string RoleName { get; set; }
        public List<Gender> Genders { get; set; }
        public string MyGender { get; set; }

    }
}

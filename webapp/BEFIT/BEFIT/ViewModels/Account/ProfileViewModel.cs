using BEFIT.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BEFIT.ViewModels.Account
{
    public class ProfileViewModel
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
       
        public DateTime Birthdate { get; set; }
        public bool Student { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfMembershipPayment { get; set; }
        public string Email { get; set; }
        public string Certificate { get; set; }
        public DateTime? DateOfGettingCertificate { get; set; }

        public User User { get; set; }
        public IList<string> Roles { get; set; }
        public string RoleName { get; set; }
        public bool isAuthorized { get; set; }

        public string Password { get; set; }

    }
}

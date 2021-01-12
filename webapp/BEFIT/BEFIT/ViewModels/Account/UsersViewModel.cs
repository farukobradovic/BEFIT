using BEFIT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BEFIT.ViewModels.Account
{
    public class UsersViewModel
    {
        public string Search { get; set; }
        public List<User> Users { get; set; }

    }
}

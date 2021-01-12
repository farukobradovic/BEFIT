using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BEFIT.Models
{
    public class DeletedUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string RoleName { get; set; }
        public DateTime DateDeleted { get; set; }
        public DateTime? DateRegistered { get; set; }
        public string Email { get; set; }


    }
}

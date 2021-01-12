using BEFIT.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BEFIT.ViewModels.Exercise
{
    public class ListaVjezbiVM
    {       
        public List<SelectListItem> Category { get; set; }
        public int CategoryId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BEFIT.ViewModels.ProgramArticle
{
    public class ProgramArticleIndexVM
    {
        public string PhotoPath { get; set; }

        public List<Rows> rows { get; set; }

        public class Rows
        {
            public int ProgramArticleId { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }


        }
    }
}

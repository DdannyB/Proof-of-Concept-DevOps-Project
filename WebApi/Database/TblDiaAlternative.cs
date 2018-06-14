using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblDiaAlternative
    {
        public long PkDiaalternativeid { get; set; }
        public long FkDiaid { get; set; }
        public string Diaalternativedescription { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblDia FkDia { get; set; }
    }
}

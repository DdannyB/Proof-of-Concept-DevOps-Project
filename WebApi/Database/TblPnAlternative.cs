using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblPnAlternative
    {
        public long PkPnalternativeid { get; set; }
        public long FkPnid { get; set; }
        public string Pnalternativedescription { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblPn FkPn { get; set; }
    }
}

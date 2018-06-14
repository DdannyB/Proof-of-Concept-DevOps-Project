using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblDnAlternative
    {
        public long PkDnalternativeid { get; set; }
        public long FkDnid { get; set; }
        public string Dnalternativedescription { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblDn FkDn { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblLbsAlternative
    {
        public long PkLbsalternativeid { get; set; }
        public long FkLbsid { get; set; }
        public string Lbsalternativedescription { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblLbs FkLbs { get; set; }
    }
}

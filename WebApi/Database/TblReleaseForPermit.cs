using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblReleaseForPermit
    {
        public long PkReleaseforpermitid { get; set; }
        public long? FkScopejobid { get; set; }
        public long FkUserid { get; set; }
        public bool Isreleasedforpermit { get; set; }
        public DateTime Releasedforpermitdate { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long? FkPermitid { get; set; }

        public TblPermit FkPermit { get; set; }
        public TblScopeJob FkScopejob { get; set; }
        public TblUser FkUser { get; set; }
    }
}

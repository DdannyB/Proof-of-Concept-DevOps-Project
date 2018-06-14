using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblScopeJobPermit
    {
        public long PkScopejobpermitid { get; set; }
        public long FkScopejobid { get; set; }
        public long FkPermitid { get; set; }
        public bool Scopejobpermitisparent { get; set; }
        public bool Scopejobpermitisactivejob { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblPermit FkPermit { get; set; }
        public TblScopeJob FkScopejob { get; set; }
    }
}

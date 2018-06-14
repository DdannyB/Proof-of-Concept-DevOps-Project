using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblSnapshotScopeJob
    {
        public long PkSnapshotscopejobid { get; set; }
        public long FkSnapshotid { get; set; }
        public long FkScopejobid { get; set; }
        public DateTime Plannedstart { get; set; }
        public DateTime Plannedfinish { get; set; }
        public DateTime Earlystart { get; set; }
        public DateTime Earlyfinish { get; set; }
        public DateTime Latestart { get; set; }
        public DateTime Latefinish { get; set; }
        public int? Totalfloat { get; set; }
        public int? Freefloat { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblScopeJob FkScopejob { get; set; }
        public TblSnapshot FkSnapshot { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblSnapshotMilestone
    {
        public long PkSnapshotmilestoneid { get; set; }
        public long FkSnapshotid { get; set; }
        public long FkMilestoneid { get; set; }
        public DateTime Plannedstart { get; set; }
        public DateTime Earlystart { get; set; }
        public DateTime Latestart { get; set; }
        public int? Totalfloat { get; set; }
        public int? Freefloat { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblMilestone FkMilestone { get; set; }
    }
}

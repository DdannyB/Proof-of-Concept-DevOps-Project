using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblSnapshot
    {
        public TblSnapshot()
        {
            TblProjectFkSnapshotactualscheduleit = new HashSet<TblProject>();
            TblProjectFkSnapshotactualsystems = new HashSet<TblProject>();
            TblProjectFkSnapshotbaselinescheduleit = new HashSet<TblProject>();
            TblProjectFkSnapshotbaselinesystems = new HashSet<TblProject>();
            TblSnapshotScopeJob = new HashSet<TblSnapshotScopeJob>();
        }

        public long PkSnapshotid { get; set; }
        public string Snapshotname { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long? FkProjectid { get; set; }
        public int Snapshotcolor { get; set; }
        public int Snapshotstatus { get; set; }

        public TblProject FkProject { get; set; }
        public ICollection<TblProject> TblProjectFkSnapshotactualscheduleit { get; set; }
        public ICollection<TblProject> TblProjectFkSnapshotactualsystems { get; set; }
        public ICollection<TblProject> TblProjectFkSnapshotbaselinescheduleit { get; set; }
        public ICollection<TblProject> TblProjectFkSnapshotbaselinesystems { get; set; }
        public ICollection<TblSnapshotScopeJob> TblSnapshotScopeJob { get; set; }
    }
}

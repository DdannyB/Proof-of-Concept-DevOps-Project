using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblTarget
    {
        public TblTarget()
        {
            TblMilestoneTarget = new HashSet<TblMilestoneTarget>();
            TblScopeJobDetailResourceTarget = new HashSet<TblScopeJobDetailResourceTarget>();
            TblScopeJobDetailTarget = new HashSet<TblScopeJobDetailTarget>();
            TblScopeJobTarget = new HashSet<TblScopeJobTarget>();
        }

        public long PkTargetid { get; set; }
        public long FkProjectid { get; set; }
        public string Description { get; set; }
        public int Targetnr { get; set; }
        public int Targetcolor { get; set; }
        public int Targetstatus { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public bool Updatetobaseline { get; set; }

        public TblProject FkProject { get; set; }
        public ICollection<TblMilestoneTarget> TblMilestoneTarget { get; set; }
        public ICollection<TblScopeJobDetailResourceTarget> TblScopeJobDetailResourceTarget { get; set; }
        public ICollection<TblScopeJobDetailTarget> TblScopeJobDetailTarget { get; set; }
        public ICollection<TblScopeJobTarget> TblScopeJobTarget { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblMilestone
    {
        public TblMilestone()
        {
            TblMilestoneTarget = new HashSet<TblMilestoneTarget>();
            TblScopeMilestone1 = new HashSet<TblScopeMilestone1>();
            TblScopeRelationFkMilestoneid1Navigation = new HashSet<TblScopeRelation>();
            TblScopeRelationFkMilestoneid2Navigation = new HashSet<TblScopeRelation>();
            TblSnapshotMilestone = new HashSet<TblSnapshotMilestone>();
        }

        public long PkMilestoneid { get; set; }
        public DateTime? Esdate { get; set; }
        public DateTime? Lsdate { get; set; }
        public DateTime? Asdate { get; set; }
        public int Startfinish { get; set; }
        public int? Progress { get; set; }
        public long? FkTemplatemilestoneid { get; set; }
        public long? FkSubsbsid { get; set; }
        public long? FkWbsid { get; set; }
        public long? FkObsid { get; set; }
        public long? FkCbsid { get; set; }
        public long? FkUnitid { get; set; }
        public long FkProjectid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public bool Iscustom { get; set; }
        public string Customdescription { get; set; }
        public DateTime? Psdate { get; set; }
        public long? FkCalendarid { get; set; }
        public string Customactivityid { get; set; }
        public int? Milestonefreefloat { get; set; }
        public int? Milestonetotalfloat { get; set; }
        public int Milestoneconstrainttype { get; set; }
        public DateTime? Milestoneconstraintdate1 { get; set; }
        public DateTime? Milestoneconstraintdate2 { get; set; }
        public string Schedulestatusdescription { get; set; }
        public int Schedulestatus { get; set; }
        public bool Scopejobignoreconstraint { get; set; }

        public TblCalendar FkCalendar { get; set; }
        public TblCbs FkCbs { get; set; }
        public TblObs FkObs { get; set; }
        public TblProject FkProject { get; set; }
        public TblSubSbs FkSubsbs { get; set; }
        public TblTemplateMilestone FkTemplatemilestone { get; set; }
        public TblUnit FkUnit { get; set; }
        public TblWbs FkWbs { get; set; }
        public ICollection<TblMilestoneTarget> TblMilestoneTarget { get; set; }
        public ICollection<TblScopeMilestone1> TblScopeMilestone1 { get; set; }
        public ICollection<TblScopeRelation> TblScopeRelationFkMilestoneid1Navigation { get; set; }
        public ICollection<TblScopeRelation> TblScopeRelationFkMilestoneid2Navigation { get; set; }
        public ICollection<TblSnapshotMilestone> TblSnapshotMilestone { get; set; }
    }
}

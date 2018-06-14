using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblScopeJob
    {
        public TblScopeJob()
        {
            TblReleaseForPermit = new HashSet<TblReleaseForPermit>();
            TblScopeJobCustomColumn = new HashSet<TblScopeJobCustomColumn>();
            TblScopeJobDetail = new HashSet<TblScopeJobDetail>();
            TblScopeJobPermit = new HashSet<TblScopeJobPermit>();
            TblScopeJobTarget = new HashSet<TblScopeJobTarget>();
            TblScopeRelationFkScopejobid1Navigation = new HashSet<TblScopeRelation>();
            TblScopeRelationFkScopejobid2Navigation = new HashSet<TblScopeRelation>();
            TblScopeRelationPosition = new HashSet<TblScopeRelationPosition>();
            TblSnapshotScopeJob = new HashSet<TblSnapshotScopeJob>();
        }

        public long PkScopejobid { get; set; }
        public long FkScopeid { get; set; }
        public long? FkLibraryscopetemplatejobid { get; set; }
        public long? FkLibraryjobid { get; set; }
        public long FkJobdataid { get; set; }
        public long? FkWorkpermitid { get; set; }
        public string Scopejobcode { get; set; }
        public int? Scopejobsortorder { get; set; }
        public DateTime? Revisionaccepteddate { get; set; }
        public bool Isenabled { get; set; }
        public string Scopejobmemo { get; set; }
        public decimal Scopejobplannedduration { get; set; }
        public string Copyprojectinfo { get; set; }
        public string Scopejobplanupdate { get; set; }
        public string Scopejobgroup { get; set; }
        public int Scopejobconstrainttype { get; set; }
        public DateTime? Scopejobconstraintdate1 { get; set; }
        public DateTime? Scopejobconstraintdate2 { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public string Schedulestatusdescription { get; set; }
        public int Schedulestatus { get; set; }
        public bool Scopejobignoreconstraint { get; set; }

        public TblJobData FkJobdata { get; set; }
        public TblLibraryJob FkLibraryjob { get; set; }
        public TblLibraryScopeTemplateJob FkLibraryscopetemplatejob { get; set; }
        public TblScope FkScope { get; set; }
        public TblWorkpermit FkWorkpermit { get; set; }
        public ICollection<TblReleaseForPermit> TblReleaseForPermit { get; set; }
        public ICollection<TblScopeJobCustomColumn> TblScopeJobCustomColumn { get; set; }
        public ICollection<TblScopeJobDetail> TblScopeJobDetail { get; set; }
        public ICollection<TblScopeJobPermit> TblScopeJobPermit { get; set; }
        public ICollection<TblScopeJobTarget> TblScopeJobTarget { get; set; }
        public ICollection<TblScopeRelation> TblScopeRelationFkScopejobid1Navigation { get; set; }
        public ICollection<TblScopeRelation> TblScopeRelationFkScopejobid2Navigation { get; set; }
        public ICollection<TblScopeRelationPosition> TblScopeRelationPosition { get; set; }
        public ICollection<TblSnapshotScopeJob> TblSnapshotScopeJob { get; set; }
    }
}

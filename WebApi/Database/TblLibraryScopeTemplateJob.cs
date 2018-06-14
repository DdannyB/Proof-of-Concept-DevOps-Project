using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblLibraryScopeTemplateJob
    {
        public TblLibraryScopeTemplateJob()
        {
            TblLibraryScopeTemplateJobBasePermit = new HashSet<TblLibraryScopeTemplateJobBasePermit>();
            TblLibraryScopeTemplateRelationFkLibraryscopetemplatejobid1Navigation = new HashSet<TblLibraryScopeTemplateRelation>();
            TblLibraryScopeTemplateRelationFkLibraryscopetemplatejobid2Navigation = new HashSet<TblLibraryScopeTemplateRelation>();
            TblLibraryScopeTemplateRelationPosition = new HashSet<TblLibraryScopeTemplateRelationPosition>();
            TblScopeJob = new HashSet<TblScopeJob>();
        }

        public long PkLibraryscopetemplatejobid { get; set; }
        public long FkLibraryscopetemplateid { get; set; }
        public long? FkLibraryjobid { get; set; }
        public long FkJobid { get; set; }
        public string Scopetemplatejobcode { get; set; }
        public int? Scopetemplatejobsortorder { get; set; }
        public DateTime? Revisionaccepteddate { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblJob FkJob { get; set; }
        public TblLibraryJob FkLibraryjob { get; set; }
        public TblLibraryScopeTemplate FkLibraryscopetemplate { get; set; }
        public ICollection<TblLibraryScopeTemplateJobBasePermit> TblLibraryScopeTemplateJobBasePermit { get; set; }
        public ICollection<TblLibraryScopeTemplateRelation> TblLibraryScopeTemplateRelationFkLibraryscopetemplatejobid1Navigation { get; set; }
        public ICollection<TblLibraryScopeTemplateRelation> TblLibraryScopeTemplateRelationFkLibraryscopetemplatejobid2Navigation { get; set; }
        public ICollection<TblLibraryScopeTemplateRelationPosition> TblLibraryScopeTemplateRelationPosition { get; set; }
        public ICollection<TblScopeJob> TblScopeJob { get; set; }
    }
}

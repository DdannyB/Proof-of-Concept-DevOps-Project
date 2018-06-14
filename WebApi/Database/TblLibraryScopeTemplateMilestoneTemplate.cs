using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblLibraryScopeTemplateMilestoneTemplate
    {
        public TblLibraryScopeTemplateMilestoneTemplate()
        {
            TblLibraryScopeTemplateRelationFkLibraryscopetemplatemilestonetemplateid1Navigation = new HashSet<TblLibraryScopeTemplateRelation>();
            TblLibraryScopeTemplateRelationFkLibraryscopetemplatemilestonetemplateid2Navigation = new HashSet<TblLibraryScopeTemplateRelation>();
            TblLibraryScopeTemplateRelationPosition = new HashSet<TblLibraryScopeTemplateRelationPosition>();
        }

        public long PkLibraryscopetemplatemilestonetemplateid { get; set; }
        public long FkLibraryscopetemplateid { get; set; }
        public long FkTemplatemilestoneid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblLibraryScopeTemplate FkLibraryscopetemplate { get; set; }
        public TblTemplateMilestone FkTemplatemilestone { get; set; }
        public ICollection<TblLibraryScopeTemplateRelation> TblLibraryScopeTemplateRelationFkLibraryscopetemplatemilestonetemplateid1Navigation { get; set; }
        public ICollection<TblLibraryScopeTemplateRelation> TblLibraryScopeTemplateRelationFkLibraryscopetemplatemilestonetemplateid2Navigation { get; set; }
        public ICollection<TblLibraryScopeTemplateRelationPosition> TblLibraryScopeTemplateRelationPosition { get; set; }
    }
}

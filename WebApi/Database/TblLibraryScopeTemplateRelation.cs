using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblLibraryScopeTemplateRelation
    {
        public TblLibraryScopeTemplateRelation()
        {
            TblLibraryScopeTemplateRelationPosition = new HashSet<TblLibraryScopeTemplateRelationPosition>();
        }

        public long PkLibraryscopetemplaterelationid { get; set; }
        public long? FkLibraryscopetemplatejobid1 { get; set; }
        public long? FkLibraryscopetemplatejobid2 { get; set; }
        public string Scopetemplaterelationtype { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long? FkLibraryscopetemplatemilestonetemplateid1 { get; set; }
        public long? FkLibraryscopetemplatemilestonetemplateid2 { get; set; }
        public int? Gcrecord { get; set; }

        public TblLibraryScopeTemplateJob FkLibraryscopetemplatejobid1Navigation { get; set; }
        public TblLibraryScopeTemplateJob FkLibraryscopetemplatejobid2Navigation { get; set; }
        public TblLibraryScopeTemplateMilestoneTemplate FkLibraryscopetemplatemilestonetemplateid1Navigation { get; set; }
        public TblLibraryScopeTemplateMilestoneTemplate FkLibraryscopetemplatemilestonetemplateid2Navigation { get; set; }
        public ICollection<TblLibraryScopeTemplateRelationPosition> TblLibraryScopeTemplateRelationPosition { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblLibraryScopeTemplateRelationPosition
    {
        public long PkLibraryscopetemplaterelationpositionid { get; set; }
        public long? FkLibraryscopetemplaterelationid { get; set; }
        public long? FkLibraryscopetemplatejobid { get; set; }
        public int Scopetemplaterelationpositionx { get; set; }
        public int Scopetemplaterelationpositiony { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long? FkLibraryscopetemplatemilestonetemplateid { get; set; }
        public int? Gcrecord { get; set; }

        public TblLibraryScopeTemplateJob FkLibraryscopetemplatejob { get; set; }
        public TblLibraryScopeTemplateMilestoneTemplate FkLibraryscopetemplatemilestonetemplate { get; set; }
        public TblLibraryScopeTemplateRelation FkLibraryscopetemplaterelation { get; set; }
    }
}

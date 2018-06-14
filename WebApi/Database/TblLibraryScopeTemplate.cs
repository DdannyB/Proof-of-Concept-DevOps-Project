using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblLibraryScopeTemplate
    {
        public TblLibraryScopeTemplate()
        {
            TblLibraryScopeTemplateJob = new HashSet<TblLibraryScopeTemplateJob>();
            TblLibraryScopeTemplateMilestoneTemplate = new HashSet<TblLibraryScopeTemplateMilestoneTemplate>();
            TblLibraryScopeTemplateProject = new HashSet<TblLibraryScopeTemplateProject>();
        }

        public long PkLibraryscopetemplateid { get; set; }
        public long? FkLibraryscopetemplaterevisioninfoid { get; set; }
        public long? FkShortcodeid { get; set; }
        public long? FkUniquecheckprojectid { get; set; }
        public string Scopetemplatecode { get; set; }
        public bool Scopetemplateisprojectcustom { get; set; }
        public string ScopetemplatedescriptionL1 { get; set; }
        public string ScopetemplatedescriptionL2 { get; set; }
        public string ScopetemplatedescriptionL3 { get; set; }
        public string ScopetemplatedescriptionL4 { get; set; }
        public string ScopetemplatedescriptionL5 { get; set; }
        public string Publishedcomputer { get; set; }
        public string Publisheduser { get; set; }
        public DateTime? Publisheddate { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblLibraryScopeTemplateRevisionInfo FkLibraryscopetemplaterevisioninfo { get; set; }
        public TblShortcode FkShortcode { get; set; }
        public TblProject FkUniquecheckproject { get; set; }
        public TblLibraryActiveScopeTemplate TblLibraryActiveScopeTemplate { get; set; }
        public ICollection<TblLibraryScopeTemplateJob> TblLibraryScopeTemplateJob { get; set; }
        public ICollection<TblLibraryScopeTemplateMilestoneTemplate> TblLibraryScopeTemplateMilestoneTemplate { get; set; }
        public ICollection<TblLibraryScopeTemplateProject> TblLibraryScopeTemplateProject { get; set; }
    }
}

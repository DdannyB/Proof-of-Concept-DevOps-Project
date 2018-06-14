using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblLibraryActiveScopeTemplate
    {
        public TblLibraryActiveScopeTemplate()
        {
            TblLibraryActiveScopeTemplateActive = new HashSet<TblLibraryActiveScopeTemplateActive>();
            TblLibraryScopeTemplateRevisionInfo = new HashSet<TblLibraryScopeTemplateRevisionInfo>();
        }

        public long PkLibraryactivescopetemplateid { get; set; }
        public long FkLibraryscopetemplateid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblLibraryScopeTemplate FkLibraryscopetemplate { get; set; }
        public TblLibraryActiveScopeTemplateTasklist TblLibraryActiveScopeTemplateTasklist { get; set; }
        public ICollection<TblLibraryActiveScopeTemplateActive> TblLibraryActiveScopeTemplateActive { get; set; }
        public ICollection<TblLibraryScopeTemplateRevisionInfo> TblLibraryScopeTemplateRevisionInfo { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblLibraryScopeTemplateRevisionInfo
    {
        public TblLibraryScopeTemplateRevisionInfo()
        {
            TblLibraryScopeTemplate = new HashSet<TblLibraryScopeTemplate>();
        }

        public long PkLibraryscopetemplaterevisioninfoid { get; set; }
        public long FkLibraryactivescopetemplateid { get; set; }
        public long FkRevisioninfoid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblLibraryActiveScopeTemplate FkLibraryactivescopetemplate { get; set; }
        public TblRevisionInfo FkRevisioninfo { get; set; }
        public ICollection<TblLibraryScopeTemplate> TblLibraryScopeTemplate { get; set; }
    }
}

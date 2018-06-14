using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblLibraryActiveScopeTemplateTasklist
    {
        public long PkLibraryactivescopetemplatetasklistid { get; set; }
        public long FkLibraryactivescopetemplateid { get; set; }
        public string Tasklist { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblLibraryActiveScopeTemplate FkLibraryactivescopetemplate { get; set; }
    }
}

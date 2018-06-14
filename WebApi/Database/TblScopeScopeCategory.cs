using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblScopeScopeCategory
    {
        public long PkScopecategoryid { get; set; }
        public long FkScopeid { get; set; }
        public long FkScopecategoryid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblScope FkScope { get; set; }
        public TblScopeCategory FkScopecategory { get; set; }
    }
}

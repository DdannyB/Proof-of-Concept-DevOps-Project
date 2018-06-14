using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblScopeScopeCustom
    {
        public long PkScopescopecustomid { get; set; }
        public long FkScopeid { get; set; }
        public long FkScopecustomid { get; set; }
        public string Customvalue { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblScope FkScope { get; set; }
        public TblScopeCustom FkScopecustom { get; set; }
    }
}

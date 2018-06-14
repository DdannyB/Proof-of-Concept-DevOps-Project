using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblScopeScopeQuality
    {
        public long PkScopescopequalityid { get; set; }
        public long FkScopequalityid { get; set; }
        public long FkScopeid { get; set; }
        public decimal Earnedquality { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public string Failreason { get; set; }

        public TblScope FkScope { get; set; }
        public TblScopeQuality FkScopequality { get; set; }
    }
}

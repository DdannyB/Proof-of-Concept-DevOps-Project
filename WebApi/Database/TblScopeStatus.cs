using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblScopeStatus
    {
        public TblScopeStatus()
        {
            TblScope = new HashSet<TblScope>();
        }

        public long PkScopestatusid { get; set; }
        public string Scopestatus { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public ICollection<TblScope> TblScope { get; set; }
    }
}

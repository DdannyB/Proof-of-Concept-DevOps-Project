using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblScopePrio
    {
        public TblScopePrio()
        {
            TblScope = new HashSet<TblScope>();
        }

        public long PkScopeprioid { get; set; }
        public string Scopepriocode { get; set; }
        public string Scopepriodescription { get; set; }
        public int Internalprio { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public ICollection<TblScope> TblScope { get; set; }
    }
}

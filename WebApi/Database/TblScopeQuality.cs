using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblScopeQuality
    {
        public TblScopeQuality()
        {
            TblScopeScopeQuality = new HashSet<TblScopeScopeQuality>();
        }

        public long PkScopequalityid { get; set; }
        public string Scopequality { get; set; }
        public bool Iserror { get; set; }
        public int Weight { get; set; }
        public long FkProjectid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblProject FkProject { get; set; }
        public ICollection<TblScopeScopeQuality> TblScopeScopeQuality { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblScopeCustom
    {
        public TblScopeCustom()
        {
            TblScopeScopeCustom = new HashSet<TblScopeScopeCustom>();
        }

        public long PkScopecustomid { get; set; }
        public string Scopecustomdescription { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public ICollection<TblScopeScopeCustom> TblScopeScopeCustom { get; set; }
    }
}

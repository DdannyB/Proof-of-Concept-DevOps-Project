using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblScopeType
    {
        public TblScopeType()
        {
            TblPermitData = new HashSet<TblPermitData>();
            TblScope = new HashSet<TblScope>();
        }

        public long PkScopetypeid { get; set; }
        public string Scopetypecode { get; set; }
        public string ScopetypedescriptionL1 { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public string ScopetypedescriptionL2 { get; set; }
        public string ScopetypedescriptionL3 { get; set; }
        public string ScopetypedescriptionL4 { get; set; }
        public string ScopetypedescriptionL5 { get; set; }

        public ICollection<TblPermitData> TblPermitData { get; set; }
        public ICollection<TblScope> TblScope { get; set; }
    }
}

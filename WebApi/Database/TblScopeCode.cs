using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblScopeCode
    {
        public TblScopeCode()
        {
            TblPermitData = new HashSet<TblPermitData>();
            TblScope = new HashSet<TblScope>();
        }

        public long PkScopecodeid { get; set; }
        public string Scopecode { get; set; }
        public string ScopecodedescriptionL1 { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public string ScopecodedescriptionL2 { get; set; }
        public string ScopecodedescriptionL3 { get; set; }
        public string ScopecodedescriptionL4 { get; set; }
        public string ScopecodedescriptionL5 { get; set; }

        public ICollection<TblPermitData> TblPermitData { get; set; }
        public ICollection<TblScope> TblScope { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblScopeCategory
    {
        public TblScopeCategory()
        {
            TblScopeScopeCategory = new HashSet<TblScopeScopeCategory>();
        }

        public long PkScopecategoryid { get; set; }
        public string ScopecategorydescriptionL1 { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public string ScopecategorydescriptionL2 { get; set; }
        public string ScopecategorydescriptionL3 { get; set; }
        public string ScopecategorydescriptionL4 { get; set; }
        public string ScopecategorydescriptionL5 { get; set; }

        public ICollection<TblScopeScopeCategory> TblScopeScopeCategory { get; set; }
    }
}

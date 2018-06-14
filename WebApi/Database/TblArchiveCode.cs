using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblArchiveCode
    {
        public TblArchiveCode()
        {
            TblPermit = new HashSet<TblPermit>();
            TblScope = new HashSet<TblScope>();
        }

        public long PkArchivecodeid { get; set; }
        public string Archivecodecode { get; set; }
        public string Archivecodedescription { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public int Archivecodeenum { get; set; }

        public ICollection<TblPermit> TblPermit { get; set; }
        public ICollection<TblScope> TblScope { get; set; }
    }
}

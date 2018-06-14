using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblCertificateColumnVisibility
    {
        public long PkCertificatecolumnvisibilityid { get; set; }
        public string Columnname { get; set; }
        public int Columnenum { get; set; }
        public bool Columnisvisible { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
    }
}

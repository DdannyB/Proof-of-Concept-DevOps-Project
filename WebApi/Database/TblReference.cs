using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblReference
    {
        public long PkReferenceid { get; set; }
        public long Key { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int? Color { get; set; }
        public int Referencetype { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
    }
}

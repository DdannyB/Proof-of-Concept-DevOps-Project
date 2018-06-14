using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblScopeMemo
    {
        public long PkScopememo { get; set; }
        public int Scopememosortorder { get; set; }
        public int Scopememotype { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
    }
}

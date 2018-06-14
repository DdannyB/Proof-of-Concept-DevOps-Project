using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblScopeWpcode
    {
        public long PkScopewpcodeid { get; set; }
        public long FkScopeid { get; set; }
        public long FkWorkpreparationcodeid { get; set; }
        public long FkUserid { get; set; }
        public int? Oldid { get; set; }
        public string Olddb { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public decimal Hours { get; set; }
        public bool Isroute { get; set; }
        public DateTime? Dateissued { get; set; }
        public DateTime? Datereceived { get; set; }
        public DateTime? Dateapproved { get; set; }
        public DateTime? Dateready { get; set; }
        public string Wpcodememo { get; set; }

        public TblScope FkScope { get; set; }
        public TblUser FkUser { get; set; }
        public TblWorkPreparationCode FkWorkpreparationcode { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblPropackExportLog
    {
        public long PkPropackexportlogid { get; set; }
        public long FkPropackexportid { get; set; }
        public int? Oldid { get; set; }
        public string Olddb { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public string Logaction { get; set; }
        public string Logreason { get; set; }
        public string Logusername { get; set; }

        public TblPropackExport FkPropackexport { get; set; }
    }
}

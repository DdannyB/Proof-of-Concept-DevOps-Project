using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblPropackExportDeliverable
    {
        public long PkPropackexportdeliverableid { get; set; }
        public long FkPropackexportid { get; set; }
        public long FkDeliverableid { get; set; }
        public int? Oldid { get; set; }
        public string Olddb { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public bool Byus { get; set; }
        public bool Bythem { get; set; }
        public bool Allowoverride { get; set; }

        public TblDeliverable FkDeliverable { get; set; }
        public TblPropackExport FkPropackexport { get; set; }
    }
}

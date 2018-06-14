using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblPropackExportSent
    {
        public TblPropackExportSent()
        {
            TblPropackExportSentImportDeliverableRaw = new HashSet<TblPropackExportSentImportDeliverableRaw>();
            TblPropackExportSentImportRaw = new HashSet<TblPropackExportSentImportRaw>();
        }

        public long PkPropackexportsentid { get; set; }
        public long? FkPropackexportid { get; set; }
        public long? FkContractorid { get; set; }
        public int? Oldid { get; set; }
        public string Olddb { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public DateTime? Lastsenddate { get; set; }
        public DateTime? Lastreceivedate { get; set; }

        public TblContractor FkContractor { get; set; }
        public TblPropackExport FkPropackexport { get; set; }
        public ICollection<TblPropackExportSentImportDeliverableRaw> TblPropackExportSentImportDeliverableRaw { get; set; }
        public ICollection<TblPropackExportSentImportRaw> TblPropackExportSentImportRaw { get; set; }
    }
}

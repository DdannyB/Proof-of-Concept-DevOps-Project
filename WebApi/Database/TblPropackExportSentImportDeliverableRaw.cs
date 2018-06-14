using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblPropackExportSentImportDeliverableRaw
    {
        public long PkPropackexportsentimportdeliverablerawid { get; set; }
        public long FkPropackexportsentid { get; set; }
        public long? DkPropackexportdeliverableid { get; set; }
        public long? DkDeliverable { get; set; }
        public string Code { get; set; }
        public string Value { get; set; }
        public bool? Byus { get; set; }
        public bool? Bythem { get; set; }
        public bool? Allowoverride { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblPropackExportSent FkPropackexportsent { get; set; }
    }
}

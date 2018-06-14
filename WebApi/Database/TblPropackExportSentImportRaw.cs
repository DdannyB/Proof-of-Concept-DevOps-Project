using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblPropackExportSentImportRaw
    {
        public long PkPropackexportsentimportrawid { get; set; }
        public long FkPropackexportsentid { get; set; }
        public long? DkPropackexportresourceid { get; set; }
        public long? DkScopejobdetailresid { get; set; }
        public int? Crew { get; set; }
        public decimal? Duration { get; set; }
        public decimal? Esthrs { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Total { get; set; }
        public string Ppresmemo { get; set; }
        public int Rowtype { get; set; }
        public bool Isimported { get; set; }
        public int Fileversion { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblPropackExportSent FkPropackexportsent { get; set; }
    }
}

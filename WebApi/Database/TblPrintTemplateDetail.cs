using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblPrintTemplateDetail
    {
        public long PkPrinttemplatedetailid { get; set; }
        public long FkPrinttemplateid { get; set; }
        public long? FkDocumentlabelid { get; set; }
        public string Reportcode { get; set; }
        public int Sortnumber { get; set; }
        public bool Isgrayscale { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public int Printtemplatedetailtype { get; set; }
        public long? FkUserreportid { get; set; }

        public TblDocumentLabel FkDocumentlabel { get; set; }
        public TblPrintTemplate FkPrinttemplate { get; set; }
        public TblUserReport FkUserreport { get; set; }
    }
}

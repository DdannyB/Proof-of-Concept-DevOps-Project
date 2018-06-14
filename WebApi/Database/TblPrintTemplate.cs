using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblPrintTemplate
    {
        public TblPrintTemplate()
        {
            TblPrintTemplateDetail = new HashSet<TblPrintTemplateDetail>();
        }

        public long PkPrinttemplateid { get; set; }
        public string Printtemplatename { get; set; }
        public string Printtemplatedescription { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public int Printtemplatetype { get; set; }

        public ICollection<TblPrintTemplateDetail> TblPrintTemplateDetail { get; set; }
    }
}

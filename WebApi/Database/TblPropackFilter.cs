using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblPropackFilter
    {
        public long PkPropackfilterid { get; set; }
        public long? FkPropackid { get; set; }
        public long? FkPropacktemplateid { get; set; }
        public int? Oldid { get; set; }
        public string Olddb { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public string Fieldname { get; set; }
        public string Filter { get; set; }
        public string Visualfilter { get; set; }

        public TblPropack FkPropack { get; set; }
        public TblPropackTemplate FkPropacktemplate { get; set; }
    }
}

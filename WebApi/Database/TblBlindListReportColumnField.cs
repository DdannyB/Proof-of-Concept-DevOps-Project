using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblBlindListReportColumnField
    {
        public long PkBlindlistreportfieldid { get; set; }
        public int Enumvalue { get; set; }
        public long FkBlindlistreportcolumnid { get; set; }
        public int Ordernr { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblBlindListReportColumn FkBlindlistreportcolumn { get; set; }
    }
}

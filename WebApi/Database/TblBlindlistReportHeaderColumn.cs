using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblBlindlistReportHeaderColumn
    {
        public long PkBlindlistreportheadercolumnid { get; set; }
        public string Name { get; set; }
        public long Ordernr { get; set; }
        public string Fieldname { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
    }
}

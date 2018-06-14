using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblReportItemPart
    {
        public long PkReportitempartid { get; set; }
        public long FkReportid { get; set; }
        public long FkBasereportitempartid { get; set; }
        public string Textvalue { get; set; }
        public bool State { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblBaseReportItemPart FkBasereportitempart { get; set; }
        public TblReport FkReport { get; set; }
    }
}

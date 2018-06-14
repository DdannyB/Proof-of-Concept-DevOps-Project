using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblUserReportFiltersToHide
    {
        public long PkUserreportfilterstohideid { get; set; }
        public long FkUserreportid { get; set; }
        public int Filterenum { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblUserReport FkUserreport { get; set; }
    }
}

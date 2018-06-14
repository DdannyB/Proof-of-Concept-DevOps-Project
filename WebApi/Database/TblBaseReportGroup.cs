using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblBaseReportGroup
    {
        public TblBaseReportGroup()
        {
            TblBaseReportItem = new HashSet<TblBaseReportItem>();
        }

        public long PkBasereportgroupid { get; set; }
        public long FkBasereportid { get; set; }
        public string Basereportgroupname { get; set; }
        public double Xpos { get; set; }
        public double Ypos { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public int? Backcolor { get; set; }
        public int? Forecolor { get; set; }
        public string Fontfamily { get; set; }
        public int Fontsize { get; set; }
        public bool Fontbold { get; set; }
        public bool Fontitalic { get; set; }
        public bool Fontunderline { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblBaseReport FkBasereport { get; set; }
        public ICollection<TblBaseReportItem> TblBaseReportItem { get; set; }
    }
}

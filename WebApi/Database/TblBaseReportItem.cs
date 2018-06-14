using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblBaseReportItem
    {
        public TblBaseReportItem()
        {
            TblBaseReportItemPart = new HashSet<TblBaseReportItemPart>();
        }

        public long PkBasereportitemid { get; set; }
        public string Basereportitemname { get; set; }
        public int Basereportitemtype { get; set; }
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
        public double Xpos { get; set; }
        public double Ypos { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public long FkBasereportgroupid { get; set; }
        public int Basereportgroupitemtype { get; set; }

        public TblBaseReportGroup FkBasereportgroup { get; set; }
        public ICollection<TblBaseReportItemPart> TblBaseReportItemPart { get; set; }
    }
}

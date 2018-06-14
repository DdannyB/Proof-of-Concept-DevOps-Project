using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblReportToolBoxItemPart
    {
        public long PkReporttoolboxitempartid { get; set; }
        public long FkReporttoolboxitemid { get; set; }
        public int Baseitemparttype { get; set; }
        public string Textvalue { get; set; }
        public double Xpos { get; set; }
        public double Ypos { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public int? Forecolor { get; set; }
        public string Fontfamily { get; set; }
        public int Fontsize { get; set; }
        public bool Fontbold { get; set; }
        public bool Fontitalic { get; set; }
        public bool Fontunderline { get; set; }
        public string Datafield { get; set; }
        public int? Orientation { get; set; }

        public TblReportToolBoxItem FkReporttoolboxitem { get; set; }
    }
}

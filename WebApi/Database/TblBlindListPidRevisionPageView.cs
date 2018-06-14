using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblBlindListPidRevisionPageView
    {
        public long PkBlindlistpidrevisionpageviewid { get; set; }
        public long FkBlindlistpidrevisionid { get; set; }
        public int Pagenumber { get; set; }
        public double Zoom { get; set; }
        public double Xpos { get; set; }
        public double Ypos { get; set; }
        public int Resolutionwidth { get; set; }
        public int Resolutionheight { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public string Viewname { get; set; }
        public bool Printview { get; set; }
        public int Currentviewwidth { get; set; }
        public int Currentviewheight { get; set; }

        public TblBlindlistPidRevision FkBlindlistpidrevision { get; set; }
    }
}

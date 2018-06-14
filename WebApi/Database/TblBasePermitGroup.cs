using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblBasePermitGroup
    {
        public TblBasePermitGroup()
        {
            TblBasePermitItem = new HashSet<TblBasePermitItem>();
        }

        public long PkBasepermitgroupid { get; set; }
        public long FkBasepermitid { get; set; }
        public string Basepermitgroupname { get; set; }
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
        public int Band { get; set; }
        public bool Groupbordervisible { get; set; }
        public bool Captionvisible { get; set; }

        public TblBasePermit FkBasepermit { get; set; }
        public ICollection<TblBasePermitItem> TblBasePermitItem { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblBasePermitItem
    {
        public TblBasePermitItem()
        {
            TblBasePermitItemAuthorization = new HashSet<TblBasePermitItemAuthorization>();
            TblBasePermitItemPart = new HashSet<TblBasePermitItemPart>();
        }

        public long PkBasepermititemid { get; set; }
        public string Basepermititemname { get; set; }
        public int Basepermititemtype { get; set; }
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
        public long FkBasepermitgroupid { get; set; }
        public bool Bordervisible { get; set; }
        public int? Borderwidth { get; set; }
        public int? Bordercolor { get; set; }

        public TblBasePermitGroup FkBasepermitgroup { get; set; }
        public ICollection<TblBasePermitItemAuthorization> TblBasePermitItemAuthorization { get; set; }
        public ICollection<TblBasePermitItemPart> TblBasePermitItemPart { get; set; }
    }
}

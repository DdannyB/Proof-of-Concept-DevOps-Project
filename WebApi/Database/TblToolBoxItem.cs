using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblToolBoxItem
    {
        public TblToolBoxItem()
        {
            TblToolBoxItemPart = new HashSet<TblToolBoxItemPart>();
        }

        public long PkToolboxitemid { get; set; }
        public string Toolboxitemname { get; set; }
        public int Forecolor { get; set; }
        public string Fontfamily { get; set; }
        public int Fontsize { get; set; }
        public bool Fontbold { get; set; }
        public bool Fontitalic { get; set; }
        public bool Fontunderline { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public bool Bordervisible { get; set; }
        public int? Borderwidth { get; set; }
        public int? Bordercolor { get; set; }

        public ICollection<TblToolBoxItemPart> TblToolBoxItemPart { get; set; }
    }
}

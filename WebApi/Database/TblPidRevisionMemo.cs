using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblPidRevisionMemo
    {
        public TblPidRevisionMemo()
        {
            TblPidRevisionLineFkPidrevisionmemoid1Navigation = new HashSet<TblPidRevisionLine>();
            TblPidRevisionLineFkPidrevisionmemoid2Navigation = new HashSet<TblPidRevisionLine>();
        }

        public long PkPidrevisionmemoid { get; set; }
        public string Description { get; set; }
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
        public int Color { get; set; }
        public float Fontsize { get; set; }
        public string Fontfamily { get; set; }
        public int Linewidth { get; set; }
        public long FkPidrevisionid { get; set; }
        public int Pagenumber { get; set; }
        public int Zorder { get; set; }
        public long? DkCopiedfrompidrevisionmemoid { get; set; }

        public TblPidRevision FkPidrevision { get; set; }
        public ICollection<TblPidRevisionLine> TblPidRevisionLineFkPidrevisionmemoid1Navigation { get; set; }
        public ICollection<TblPidRevisionLine> TblPidRevisionLineFkPidrevisionmemoid2Navigation { get; set; }
    }
}

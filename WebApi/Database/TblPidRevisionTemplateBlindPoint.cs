using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblPidRevisionTemplateBlindPoint
    {
        public TblPidRevisionTemplateBlindPoint()
        {
            TblPidRevisionLineFkPidrevisiontemplateblindpointid1Navigation = new HashSet<TblPidRevisionLine>();
            TblPidRevisionLineFkPidrevisiontemplateblindpointid2Navigation = new HashSet<TblPidRevisionLine>();
        }

        public long PkPidrevisiontemplateblindpointid { get; set; }
        public long FkTemplateblindpointid { get; set; }
        public double Xpos { get; set; }
        public double Ypos { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public int Resolutionwidth { get; set; }
        public int Resoultionheight { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public bool Showref { get; set; }
        public string Refid { get; set; }
        public int Refbox { get; set; }
        public int Linewidth { get; set; }
        public long FkPidrevisionid { get; set; }
        public int Pagenumber { get; set; }
        public int Zorder { get; set; }
        public float? Regularfontsize { get; set; }
        public string Regularfontfamily { get; set; }
        public float? Referencefontsize { get; set; }
        public string Referencefontfamily { get; set; }
        public long? DkCopiedfrompidrevisiontemplateblindpointid { get; set; }

        public TblPidRevision FkPidrevision { get; set; }
        public TblTemplateBlindPoint FkTemplateblindpoint { get; set; }
        public ICollection<TblPidRevisionLine> TblPidRevisionLineFkPidrevisiontemplateblindpointid1Navigation { get; set; }
        public ICollection<TblPidRevisionLine> TblPidRevisionLineFkPidrevisiontemplateblindpointid2Navigation { get; set; }
    }
}

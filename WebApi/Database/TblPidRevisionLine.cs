using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblPidRevisionLine
    {
        public long PkPidrevisionlineid { get; set; }
        public long? FkPidrevisionmemoid1 { get; set; }
        public long? FkPidrevisionmemoid2 { get; set; }
        public long? FkPidrevisiontemplateblindpointid1 { get; set; }
        public long? FkPidrevisiontemplateblindpointid2 { get; set; }
        public double? Xpos1 { get; set; }
        public double? Ypos1 { get; set; }
        public double? Xpos2 { get; set; }
        public double? Ypos2 { get; set; }
        public int Resolutionwidth { get; set; }
        public int Resolutionheight { get; set; }
        public int? Lineend1 { get; set; }
        public int? Lineend2 { get; set; }
        public int? Color { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public int Linewidth { get; set; }
        public long FkPidrevisionid { get; set; }
        public int Pagenumber { get; set; }
        public int Zorder { get; set; }
        public long? DkCopiedfrompidrevisionlineid { get; set; }

        public TblPidRevision FkPidrevision { get; set; }
        public TblPidRevisionMemo FkPidrevisionmemoid1Navigation { get; set; }
        public TblPidRevisionMemo FkPidrevisionmemoid2Navigation { get; set; }
        public TblPidRevisionTemplateBlindPoint FkPidrevisiontemplateblindpointid1Navigation { get; set; }
        public TblPidRevisionTemplateBlindPoint FkPidrevisiontemplateblindpointid2Navigation { get; set; }
    }
}

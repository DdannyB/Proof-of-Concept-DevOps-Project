using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblBlindProjectMainPhaseSubPhaseReleaseFinish
    {
        public long PkBlindprojectmainphasesubphasereleasefinishid { get; set; }
        public long? FkProjectid { get; set; }
        public long FkMainphaseid { get; set; }
        public long FkSubphaseid { get; set; }
        public DateTime? Releaseddate { get; set; }
        public string Releasedby { get; set; }
        public DateTime? Finisheddate { get; set; }
        public string Finishedby { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long FkBlindlistid { get; set; }

        public TblBlindList FkBlindlist { get; set; }
        public TblMainPhase FkMainphase { get; set; }
        public TblProject FkProject { get; set; }
        public TblSubPhase FkSubphase { get; set; }
    }
}

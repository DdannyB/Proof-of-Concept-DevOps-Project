using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblBlindTypeNormPosActivityNormbase
    {
        public TblBlindTypeNormPosActivityNormbase()
        {
            TblBlindTypeNormPosActivityNormbaseReference = new HashSet<TblBlindTypeNormPosActivityNormbaseReference>();
        }

        public long PkBlindtypenormposactivitynormbaseid { get; set; }
        public long FkBlindtypenormposid { get; set; }
        public long FkActivityid { get; set; }
        public long? FkMainphaseid { get; set; }
        public long? FkSubphaseid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblActivity FkActivity { get; set; }
        public TblBlindTypeNormPos FkBlindtypenormpos { get; set; }
        public TblMainPhase FkMainphase { get; set; }
        public TblSubPhase FkSubphase { get; set; }
        public ICollection<TblBlindTypeNormPosActivityNormbaseReference> TblBlindTypeNormPosActivityNormbaseReference { get; set; }
    }
}

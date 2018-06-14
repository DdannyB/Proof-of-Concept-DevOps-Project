using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblBlindTypeNormPosActivity
    {
        public TblBlindTypeNormPosActivity()
        {
            TblBlindTypeNormPosActivityLabel = new HashSet<TblBlindTypeNormPosActivityLabel>();
        }

        public long PkBlindtypenormposactivityid { get; set; }
        public long FkBlindtypenormposid { get; set; }
        public long FkActivityid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblActivity FkActivity { get; set; }
        public TblBlindTypeNormPos FkBlindtypenormpos { get; set; }
        public ICollection<TblBlindTypeNormPosActivityLabel> TblBlindTypeNormPosActivityLabel { get; set; }
    }
}

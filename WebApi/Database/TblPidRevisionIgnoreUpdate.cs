using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblPidRevisionIgnoreUpdate
    {
        public long PkPidrevisionignoreupdateid { get; set; }
        public long? FkBlindlistid { get; set; }
        public long? FkScopeid { get; set; }
        public DateTime? Ignoredate { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblBlindList FkBlindlist { get; set; }
        public TblScope FkScope { get; set; }
    }
}

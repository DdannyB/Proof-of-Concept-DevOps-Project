using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblIsolationActivityRevertReason
    {
        public long PkIsolationactivityrevertreasonid { get; set; }
        public long FkBlindpointactivityid { get; set; }
        public long FkUserid { get; set; }
        public string Revertreason { get; set; }
        public int Activitystatus { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblBlindPointActivity FkBlindpointactivity { get; set; }
        public TblUser FkUser { get; set; }
    }
}

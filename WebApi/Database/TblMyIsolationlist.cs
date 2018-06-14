using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblMyIsolationlist
    {
        public long PkMyisolationlistid { get; set; }
        public long FkIsolationlistid { get; set; }
        public long FkUserid { get; set; }
        public long? FkMainphaseid { get; set; }
        public long? FkSubphaseid { get; set; }
        public bool Visible { get; set; }

        public TblBlindList FkIsolationlist { get; set; }
        public TblUser FkUser { get; set; }
    }
}

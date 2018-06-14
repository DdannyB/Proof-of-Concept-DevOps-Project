using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class ActivityLog
    {
        public long PkActivitylogid { get; set; }
        public long DkUserid { get; set; }
        public long DkIsolationpointactivityid { get; set; }
        public string Action { get; set; }
        public string Remarks { get; set; }
        public string User { get; set; }
        public string Carduser { get; set; }
        public DateTime Timestamp { get; set; }
    }
}

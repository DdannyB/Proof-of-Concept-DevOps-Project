using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblTimekeepingEntryLog
    {
        public long PkTimekeepingentrylogid { get; set; }
        public long FkTimekeepingentryid { get; set; }
        public string Previousstate { get; set; }
        public string Newstate { get; set; }
        public string Remark { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblTimekeepingEntry FkTimekeepingentry { get; set; }
    }
}

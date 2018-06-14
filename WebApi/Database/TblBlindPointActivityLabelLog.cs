using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblBlindPointActivityLabelLog
    {
        public long PkBlindpointlabellogid { get; set; }
        public long FkBlindpointactivitylabelid { get; set; }
        public long? Blindlistid { get; set; }
        public long Blindpointid { get; set; }
        public long Activityid { get; set; }
        public long Basereportid { get; set; }
        public bool? Printed { get; set; }
        public string Printby { get; set; }
        public DateTime? Printdate { get; set; }
        public bool? Placed { get; set; }
        public string Placedby { get; set; }
        public DateTime? Placeddate { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long? FkBlindpointactivityid { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblBlindPointActivityPdaLog
    {
        public long PkBlindpointactivitypdalogid { get; set; }
        public string Logtype { get; set; }
        public string Device { get; set; }
        public string Message { get; set; }
        public string Description { get; set; }
        public string Changeuser { get; set; }
        public bool Failed { get; set; }
        public string Failedreason { get; set; }
        public string Exceptionmessage { get; set; }
        public string Exceptionstacktrace { get; set; }
        public string Exceptioninnermessage { get; set; }
        public string Exceptioninnerstacktrace { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public DateTime? Changedate { get; set; }
        public long? ActivityId { get; set; }
        public string TaskType { get; set; }
        public string DockingStation { get; set; }
    }
}

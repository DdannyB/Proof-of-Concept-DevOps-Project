using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblChangeRequestLog
    {
        public long PkChangerequestlogid { get; set; }
        public long FkActivechangerequestid { get; set; }
        public long FkUserid { get; set; }
        public DateTime Logdate { get; set; }
        public string Logaction { get; set; }
        public string Loginfo { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblActiveChangeRequest FkActivechangerequest { get; set; }
        public TblUser FkUser { get; set; }
    }
}

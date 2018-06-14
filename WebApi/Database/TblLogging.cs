using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblLogging
    {
        public long PkLoggingid { get; set; }
        public string Form { get; set; }
        public string Functionname { get; set; }
        public string Logaction { get; set; }
        public long FkWeldituser { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblUser FkWeldituserNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblSystemLog
    {
        public long PkSystemlogid { get; set; }
        public string Application { get; set; }
        public string Functionname { get; set; }
        public string Logaction { get; set; }
        public string Username { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
    }
}

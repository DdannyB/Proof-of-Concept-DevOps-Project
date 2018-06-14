using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblBlindPointLog
    {
        public long PkBlindpointlogid { get; set; }
        public long FkBlindpointid { get; set; }
        public DateTime Logdate { get; set; }
        public string Logaction { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public int Logtype { get; set; }
        public string Loguser { get; set; }

        public TblBlindPoint FkBlindpoint { get; set; }
    }
}

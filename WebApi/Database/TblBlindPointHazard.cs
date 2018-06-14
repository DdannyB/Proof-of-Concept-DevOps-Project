using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblBlindPointHazard
    {
        public long PkBlindpointhazardid { get; set; }
        public long FkBlindpointid { get; set; }
        public long FkHazardid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblBlindPoint FkBlindpoint { get; set; }
        public TblHazard FkHazard { get; set; }
    }
}

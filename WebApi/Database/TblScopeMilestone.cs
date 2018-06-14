using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblScopeMilestone
    {
        public long PkScopemilestoneid { get; set; }
        public long? FkScopeid { get; set; }
        public long? FkMilestoneid { get; set; }
        public int? Oldid { get; set; }
        public string Olddb { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblTemplateMilestone FkMilestone { get; set; }
        public TblScope FkScope { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblBasePermitMaintenanceStrategyKeyword
    {
        public long PkBasepermitmaintenancestrategykeywordid { get; set; }
        public long FkBasepermitmaintenancestrategyid { get; set; }
        public string Keyword { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblBasePermitMaintenanceStrategy FkBasepermitmaintenancestrategy { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblBasePermitMaintenanceStrategyBasePermitItemPart
    {
        public long PkBasepermitmaintenancestrategybasepermititempartid { get; set; }
        public long FkBasepermitmaintenancestrategyid { get; set; }
        public long FkBasepermititempartid { get; set; }
        public bool? State { get; set; }
        public string Value { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblBasePermitItemPart FkBasepermititempart { get; set; }
        public TblBasePermitMaintenanceStrategy FkBasepermitmaintenancestrategy { get; set; }
    }
}

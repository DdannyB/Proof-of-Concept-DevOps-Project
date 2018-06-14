using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblBasePermitMaintenanceStrategy
    {
        public TblBasePermitMaintenanceStrategy()
        {
            TblBasePermitMaintenanceStrategyBasePermitItemPart = new HashSet<TblBasePermitMaintenanceStrategyBasePermitItemPart>();
            TblBasePermitMaintenanceStrategyDetails = new HashSet<TblBasePermitMaintenanceStrategyDetails>();
            TblBasePermitMaintenanceStrategyKeyword = new HashSet<TblBasePermitMaintenanceStrategyKeyword>();
        }

        public long PkBasepermitmaintenancestrategyid { get; set; }
        public string Basepermitmaintenancestrategyname { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long FkBasepermitid { get; set; }
        public DateTime? Freezedate { get; set; }
        public string Freezeuser { get; set; }

        public TblBasePermit FkBasepermit { get; set; }
        public ICollection<TblBasePermitMaintenanceStrategyBasePermitItemPart> TblBasePermitMaintenanceStrategyBasePermitItemPart { get; set; }
        public ICollection<TblBasePermitMaintenanceStrategyDetails> TblBasePermitMaintenanceStrategyDetails { get; set; }
        public ICollection<TblBasePermitMaintenanceStrategyKeyword> TblBasePermitMaintenanceStrategyKeyword { get; set; }
    }
}

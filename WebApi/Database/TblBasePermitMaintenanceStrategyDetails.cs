using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblBasePermitMaintenanceStrategyDetails
    {
        public long PkBasepermitmaintenancestrategydetailsid { get; set; }
        public long FkBasepermitmaintenancestrategyid { get; set; }
        public long? FkLibraryactivejobid { get; set; }
        public long? FkResourceid { get; set; }
        public long? FkCircumstanceid { get; set; }
        public long? FkShortcodeid { get; set; }
        public long? FkMainphaseid { get; set; }
        public long? FkSubphaseid { get; set; }
        public long? FkHazardid { get; set; }
        public long? FkUnitid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblBasePermitMaintenanceStrategy FkBasepermitmaintenancestrategy { get; set; }
        public TblCircumstance FkCircumstance { get; set; }
        public TblHazard FkHazard { get; set; }
        public TblLibraryActiveJob FkLibraryactivejob { get; set; }
        public TblMainPhase FkMainphase { get; set; }
        public TblResource FkResource { get; set; }
        public TblShortcode FkShortcode { get; set; }
        public TblSubPhase FkSubphase { get; set; }
        public TblUnit FkUnit { get; set; }
    }
}

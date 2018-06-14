using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblHazard
    {
        public TblHazard()
        {
            TblBasePermitMaintenanceStrategyDetails = new HashSet<TblBasePermitMaintenanceStrategyDetails>();
            TblBlindPointHazard = new HashSet<TblBlindPointHazard>();
            TblHazardSymbol = new HashSet<TblHazardSymbol>();
            TblScopeHazard = new HashSet<TblScopeHazard>();
            TblTemplateBlindPointHazard = new HashSet<TblTemplateBlindPointHazard>();
        }

        public long PkHazardid { get; set; }
        public string Hazardcode { get; set; }
        public string Hazarddescription { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public ICollection<TblBasePermitMaintenanceStrategyDetails> TblBasePermitMaintenanceStrategyDetails { get; set; }
        public ICollection<TblBlindPointHazard> TblBlindPointHazard { get; set; }
        public ICollection<TblHazardSymbol> TblHazardSymbol { get; set; }
        public ICollection<TblScopeHazard> TblScopeHazard { get; set; }
        public ICollection<TblTemplateBlindPointHazard> TblTemplateBlindPointHazard { get; set; }
    }
}

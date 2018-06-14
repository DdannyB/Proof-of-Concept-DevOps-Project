using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblUnit
    {
        public TblUnit()
        {
            TblBasePermitMaintenanceStrategyDetails = new HashSet<TblBasePermitMaintenanceStrategyDetails>();
            TblMilestone = new HashSet<TblMilestone>();
            TblPermitData = new HashSet<TblPermitData>();
            TblPipeline = new HashSet<TblPipeline>();
            TblPlantData = new HashSet<TblPlantData>();
            TblProgressResponsible = new HashSet<TblProgressResponsible>();
        }

        public long PkUnitid { get; set; }
        public string Unit { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public string Unitdescription { get; set; }
        public long FkProcessareaid { get; set; }
        public string Exportcode { get; set; }

        public TblProcessarea FkProcessarea { get; set; }
        public ICollection<TblBasePermitMaintenanceStrategyDetails> TblBasePermitMaintenanceStrategyDetails { get; set; }
        public ICollection<TblMilestone> TblMilestone { get; set; }
        public ICollection<TblPermitData> TblPermitData { get; set; }
        public ICollection<TblPipeline> TblPipeline { get; set; }
        public ICollection<TblPlantData> TblPlantData { get; set; }
        public ICollection<TblProgressResponsible> TblProgressResponsible { get; set; }
    }
}

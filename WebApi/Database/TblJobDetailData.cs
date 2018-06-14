using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblJobDetailData
    {
        public TblJobDetailData()
        {
            TblJobDetail = new HashSet<TblJobDetail>();
            TblScopeJobDetail = new HashSet<TblScopeJobDetail>();
        }

        public long PkJobdetaildataid { get; set; }
        public long? FkAreacodeid { get; set; }
        public long? FkBuildingid { get; set; }
        public long? FkElevationunitofmeasurementid { get; set; }
        public string Jobdetailname { get; set; }
        public string Jobdetailmemo { get; set; }
        public string Jobdetaillocation { get; set; }
        public decimal? Jobdetailelevation { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblAreaCode FkAreacode { get; set; }
        public TblBuilding FkBuilding { get; set; }
        public TblUnitOfMeasurement FkElevationunitofmeasurement { get; set; }
        public ICollection<TblJobDetail> TblJobDetail { get; set; }
        public ICollection<TblScopeJobDetail> TblScopeJobDetail { get; set; }
    }
}

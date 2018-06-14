using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblBuilding
    {
        public TblBuilding()
        {
            TblJobDetailData = new HashSet<TblJobDetailData>();
            TblPermitData = new HashSet<TblPermitData>();
            TblPlantData = new HashSet<TblPlantData>();
            TblScope = new HashSet<TblScope>();
        }

        public long PkBuildingid { get; set; }
        public string Buildingcode { get; set; }
        public string Buildingdescription { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public ICollection<TblJobDetailData> TblJobDetailData { get; set; }
        public ICollection<TblPermitData> TblPermitData { get; set; }
        public ICollection<TblPlantData> TblPlantData { get; set; }
        public ICollection<TblScope> TblScope { get; set; }
    }
}

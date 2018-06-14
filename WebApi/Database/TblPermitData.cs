using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblPermitData
    {
        public long PkPermitdataid { get; set; }
        public long FkPermitid { get; set; }
        public long? FkAreacodeid { get; set; }
        public long? FkBuildingid { get; set; }
        public long? FkCbsid { get; set; }
        public long? FkElevationunitofmeasurementid { get; set; }
        public long? FkObsid { get; set; }
        public long? FkPlantdataid { get; set; }
        public long? FkProcessareaid { get; set; }
        public long? FkSbsid1 { get; set; }
        public long? FkSbsid2 { get; set; }
        public long? FkSbsid3 { get; set; }
        public long? FkScopecodeid { get; set; }
        public long? FkScopetypeid { get; set; }
        public long? FkSubdisciplineid { get; set; }
        public long? FkUnitid { get; set; }
        public long? FkWbsid { get; set; }
        public int? Crew { get; set; }
        public decimal? Elevation { get; set; }
        public DateTime? Finishdate { get; set; }
        public string Location { get; set; }
        public string Notificationno { get; set; }
        public int? Scopeno { get; set; }
        public DateTime? Startdate { get; set; }
        public string Stoppointdescription { get; set; }
        public string Stoppointno { get; set; }
        public string Wono { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long? FkMaincontractorid { get; set; }

        public TblAreaCode FkAreacode { get; set; }
        public TblBuilding FkBuilding { get; set; }
        public TblCbs FkCbs { get; set; }
        public TblUnitOfMeasurement FkElevationunitofmeasurement { get; set; }
        public TblContractor FkMaincontractor { get; set; }
        public TblObs FkObs { get; set; }
        public TblPermit FkPermit { get; set; }
        public TblPlantData FkPlantdata { get; set; }
        public TblProcessarea FkProcessarea { get; set; }
        public TblSubSbs FkSbsid1Navigation { get; set; }
        public TblSubSbs FkSbsid2Navigation { get; set; }
        public TblSubSbs FkSbsid3Navigation { get; set; }
        public TblScopeCode FkScopecode { get; set; }
        public TblScopeType FkScopetype { get; set; }
        public TblSubDiscipline FkSubdiscipline { get; set; }
        public TblUnit FkUnit { get; set; }
        public TblWbs FkWbs { get; set; }
    }
}

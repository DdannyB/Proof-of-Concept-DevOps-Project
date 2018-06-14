using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblPlantData
    {
        public TblPlantData()
        {
            InverseFkPlantdatamain = new HashSet<TblPlantData>();
            TblAttachment = new HashSet<TblAttachment>();
            TblBlindList = new HashSet<TblBlindList>();
            TblCertificate = new HashSet<TblCertificate>();
            TblChangeRequest = new HashSet<TblChangeRequest>();
            TblChangeRequestAdditionalPlantData = new HashSet<TblChangeRequestAdditionalPlantData>();
            TblPermitData = new HashSet<TblPermitData>();
            TblPipelineConnection = new HashSet<TblPipelineConnection>();
            TblPlantDataCustom = new HashSet<TblPlantDataCustom>();
            TblPlantDataDocumentLabel = new HashSet<TblPlantDataDocumentLabel>();
            TblPlantDataPid = new HashSet<TblPlantDataPid>();
            TblPlantDataTestSystem = new HashSet<TblPlantDataTestSystem>();
            TblScopeFkPlantdata = new HashSet<TblScope>();
            TblScopeFkPlantdatamain = new HashSet<TblScope>();
            TblTemplateBlindpointPlantdata = new HashSet<TblTemplateBlindpointPlantdata>();
        }

        public long PkPlantdataid { get; set; }
        public string Equipmenttag { get; set; }
        public string Equipmenttagdescription { get; set; }
        public string Functionallocation { get; set; }
        public long? FkPlantdatamainid { get; set; }
        public string Sapeqptnr { get; set; }
        public int Pdlevel { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long FkUnitid { get; set; }
        public DateTime? Isdeleted { get; set; }
        public long FkShortcodeid { get; set; }
        public long? FkSubsbsid1 { get; set; }
        public long? FkSubsbsid2 { get; set; }
        public long? FkSubsbsid3 { get; set; }
        public decimal? Consequencecost { get; set; }
        public string Consequencecostmemo { get; set; }
        public string Plantdatalocation { get; set; }
        public long? FkAreacodeid { get; set; }
        public long? FkBuildingid { get; set; }
        public decimal? Elevation { get; set; }
        public long? FkElevationunitofmeasurementid { get; set; }
        public bool Sce { get; set; }
        public string Xcoordinate { get; set; }
        public string Ycoordinate { get; set; }
        public string Zcoordinate { get; set; }
        public decimal? Longitude { get; set; }
        public decimal? Latitude { get; set; }

        public TblAreaCode FkAreacode { get; set; }
        public TblBuilding FkBuilding { get; set; }
        public TblUnitOfMeasurement FkElevationunitofmeasurement { get; set; }
        public TblPlantData FkPlantdatamain { get; set; }
        public TblShortcode FkShortcode { get; set; }
        public TblSubSbs FkSubsbsid1Navigation { get; set; }
        public TblSubSbs FkSubsbsid2Navigation { get; set; }
        public TblSubSbs FkSubsbsid3Navigation { get; set; }
        public TblUnit FkUnit { get; set; }
        public ICollection<TblPlantData> InverseFkPlantdatamain { get; set; }
        public ICollection<TblAttachment> TblAttachment { get; set; }
        public ICollection<TblBlindList> TblBlindList { get; set; }
        public ICollection<TblCertificate> TblCertificate { get; set; }
        public ICollection<TblChangeRequest> TblChangeRequest { get; set; }
        public ICollection<TblChangeRequestAdditionalPlantData> TblChangeRequestAdditionalPlantData { get; set; }
        public ICollection<TblPermitData> TblPermitData { get; set; }
        public ICollection<TblPipelineConnection> TblPipelineConnection { get; set; }
        public ICollection<TblPlantDataCustom> TblPlantDataCustom { get; set; }
        public ICollection<TblPlantDataDocumentLabel> TblPlantDataDocumentLabel { get; set; }
        public ICollection<TblPlantDataPid> TblPlantDataPid { get; set; }
        public ICollection<TblPlantDataTestSystem> TblPlantDataTestSystem { get; set; }
        public ICollection<TblScope> TblScopeFkPlantdata { get; set; }
        public ICollection<TblScope> TblScopeFkPlantdatamain { get; set; }
        public ICollection<TblTemplateBlindpointPlantdata> TblTemplateBlindpointPlantdata { get; set; }
    }
}

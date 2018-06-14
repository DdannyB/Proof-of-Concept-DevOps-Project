using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblMaterialLibrary
    {
        public TblMaterialLibrary()
        {
            TblCertificate = new HashSet<TblCertificate>();
            TblCertificateMaterialLibrary = new HashSet<TblCertificateMaterialLibrary>();
            TblMaterialBom = new HashSet<TblMaterialBom>();
            TblMaterialPipeSpecLibrary = new HashSet<TblMaterialPipeSpecLibrary>();
            TblPart = new HashSet<TblPart>();
            TblWeldConnectionPart = new HashSet<TblWeldConnectionPart>();
        }

        public long PkMateriallibraryid { get; set; }
        public long FkSubmaterialgroupid { get; set; }
        public long FkUnitofmeasurementid { get; set; }
        public long? FkContractorid { get; set; }
        public string Articlenr { get; set; }
        public string Articledescription { get; set; }
        public decimal? Price { get; set; }
        public string Dimension { get; set; }
        public string Material { get; set; }
        public string Mattype { get; set; }
        public string Lngtxt { get; set; }
        public bool? Isstock { get; set; }
        public string Legacyarticlenr1 { get; set; }
        public string Legacyarticlenr2 { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public int? Length { get; set; }
        public long? FkThicknessid1 { get; set; }
        public long? FkThicknessid2 { get; set; }
        public bool? Inspectionrequired { get; set; }
        public long? FkDiaid { get; set; }
        public long? FkLbsid { get; set; }
        public long? FkDnid { get; set; }
        public long? FkPnid { get; set; }
        public long? FkScheduleid { get; set; }
        public long? FkBoltdiameterdiaid { get; set; }
        public long? FkBoltdiameterdnid { get; set; }
        public long? FkBasematerialid { get; set; }
        public long? FkPipetypeid { get; set; }
        public decimal? Boltlengthinch { get; set; }
        public decimal? Boltlengthmm { get; set; }

        public TblBaseMaterial FkBasematerial { get; set; }
        public TblDia FkBoltdiameterdia { get; set; }
        public TblDn FkBoltdiameterdn { get; set; }
        public TblContractor FkContractor { get; set; }
        public TblDia FkDia { get; set; }
        public TblDn FkDn { get; set; }
        public TblLbs FkLbs { get; set; }
        public TblPipeType FkPipetype { get; set; }
        public TblPn FkPn { get; set; }
        public TblSchedule FkSchedule { get; set; }
        public TblSubMaterialGroup FkSubmaterialgroup { get; set; }
        public TblThickness FkThicknessid1Navigation { get; set; }
        public TblThickness FkThicknessid2Navigation { get; set; }
        public TblUnitOfMeasurement FkUnitofmeasurement { get; set; }
        public ICollection<TblCertificate> TblCertificate { get; set; }
        public ICollection<TblCertificateMaterialLibrary> TblCertificateMaterialLibrary { get; set; }
        public ICollection<TblMaterialBom> TblMaterialBom { get; set; }
        public ICollection<TblMaterialPipeSpecLibrary> TblMaterialPipeSpecLibrary { get; set; }
        public ICollection<TblPart> TblPart { get; set; }
        public ICollection<TblWeldConnectionPart> TblWeldConnectionPart { get; set; }
    }
}

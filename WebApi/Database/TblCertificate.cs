using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblCertificate
    {
        public TblCertificate()
        {
            TblAttachment = new HashSet<TblAttachment>();
            TblCertificateCertificateNorm = new HashSet<TblCertificateCertificateNorm>();
            TblCertificateCustomValue = new HashSet<TblCertificateCustomValue>();
            TblCertificateDocumentLabel = new HashSet<TblCertificateDocumentLabel>();
            TblCertificateInspection = new HashSet<TblCertificateInspection>();
            TblCertificateMaterialLibrary = new HashSet<TblCertificateMaterialLibrary>();
            TblPart = new HashSet<TblPart>();
            TblWeldConnectionPart = new HashSet<TblWeldConnectionPart>();
        }

        public long PkCertificateid { get; set; }
        public long FkCertificategroupid { get; set; }
        public string Customattestnr { get; set; }
        public string Chargenr { get; set; }
        public string Material { get; set; }
        public string Description { get; set; }
        public decimal? Qty { get; set; }
        public string Size { get; set; }
        public bool Ismatlibrary { get; set; }
        public string Articlenr { get; set; }
        public string Info { get; set; }
        public string Remarks { get; set; }
        public string Scopenr { get; set; }
        public string Stoppointnr { get; set; }
        public string Wonr { get; set; }
        public string Projectnr { get; set; }
        public string Pdfattestnr { get; set; }
        public decimal? Matlength { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long? FkUnitofmeasurementid { get; set; }
        public long? FkUserid { get; set; }
        public DateTime Certificatedate { get; set; }
        public DateTime? Validuntilldate { get; set; }
        public bool Needsinspection { get; set; }
        public long FkContractorid { get; set; }
        public string Purchasingnr { get; set; }
        public long? FkCertificatetypeid { get; set; }
        public long? FkPlantdataid { get; set; }
        public long? FkMateriallibraryid { get; set; }
        public string Prefix { get; set; }
        public long? Autonumber { get; set; }
        public DateTime? Examinationdate { get; set; }
        public DateTime? Reexaminationdate { get; set; }
        public long? FkProjectid { get; set; }
        public string Matbatch { get; set; }
        public long? FkDiaid { get; set; }
        public long? FkDnid { get; set; }
        public long? FkPnid { get; set; }
        public long? FkLbsid { get; set; }
        public long? FkBasematerialid { get; set; }
        public long? FkPipetypeid { get; set; }
        public long? FkScheduleid { get; set; }
        public long? FkThicknessid { get; set; }

        public TblBaseMaterial FkBasematerial { get; set; }
        public TblCertificateGroup FkCertificategroup { get; set; }
        public TblCertificateType FkCertificatetype { get; set; }
        public TblContractor FkContractor { get; set; }
        public TblDia FkDia { get; set; }
        public TblDn FkDn { get; set; }
        public TblLbs FkLbs { get; set; }
        public TblMaterialLibrary FkMateriallibrary { get; set; }
        public TblPipeType FkPipetype { get; set; }
        public TblPlantData FkPlantdata { get; set; }
        public TblPn FkPn { get; set; }
        public TblProject FkProject { get; set; }
        public TblSchedule FkSchedule { get; set; }
        public TblThickness FkThickness { get; set; }
        public TblUnitOfMeasurement FkUnitofmeasurement { get; set; }
        public TblUser FkUser { get; set; }
        public ICollection<TblAttachment> TblAttachment { get; set; }
        public ICollection<TblCertificateCertificateNorm> TblCertificateCertificateNorm { get; set; }
        public ICollection<TblCertificateCustomValue> TblCertificateCustomValue { get; set; }
        public ICollection<TblCertificateDocumentLabel> TblCertificateDocumentLabel { get; set; }
        public ICollection<TblCertificateInspection> TblCertificateInspection { get; set; }
        public ICollection<TblCertificateMaterialLibrary> TblCertificateMaterialLibrary { get; set; }
        public ICollection<TblPart> TblPart { get; set; }
        public ICollection<TblWeldConnectionPart> TblWeldConnectionPart { get; set; }
    }
}

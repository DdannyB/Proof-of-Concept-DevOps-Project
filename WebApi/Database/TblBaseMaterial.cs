using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblBaseMaterial
    {
        public TblBaseMaterial()
        {
            TblBoltingFkBoltBasematerial = new HashSet<TblBolting>();
            TblBoltingFkBoltCertificate = new HashSet<TblBolting>();
            TblBoltingFkFlangeBasematerial = new HashSet<TblBolting>();
            TblBoltingFkGasketBasematerial = new HashSet<TblBolting>();
            TblBoltingFkNutBasematerial = new HashSet<TblBolting>();
            TblBoltingFkWashersBasematerial = new HashSet<TblBolting>();
            TblCertificate = new HashSet<TblCertificate>();
            TblMaterialLibrary = new HashSet<TblMaterialLibrary>();
            TblNdeRequest = new HashSet<TblNdeRequest>();
            TblPart = new HashSet<TblPart>();
            TblTemplateBlindPointFkBoltBasematerial = new HashSet<TblTemplateBlindPoint>();
            TblTemplateBlindPointFkBoltCertificate = new HashSet<TblTemplateBlindPoint>();
            TblTemplateBlindPointFkFlangeBasematerial = new HashSet<TblTemplateBlindPoint>();
            TblTemplateBlindPointFkGasketBasematerial = new HashSet<TblTemplateBlindPoint>();
            TblTemplateBlindPointFkNutBasematerial = new HashSet<TblTemplateBlindPoint>();
            TblTemplateBlindPointFkWashersBasematerial = new HashSet<TblTemplateBlindPoint>();
            TblWeldConnectionPart = new HashSet<TblWeldConnectionPart>();
            TblWeldProcedureQualificationRecordFkPartabasematerial = new HashSet<TblWeldProcedureQualificationRecord>();
            TblWeldProcedureQualificationRecordFkPartbbasematerial = new HashSet<TblWeldProcedureQualificationRecord>();
            TblWeldProcedureSpecificationFkPartabasematerial = new HashSet<TblWeldProcedureSpecification>();
            TblWeldProcedureSpecificationFkPartbbasematerial = new HashSet<TblWeldProcedureSpecification>();
        }

        public long PkBasematerialid { get; set; }
        public string Basematerialdescription { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long? FkBasematerialgroupid { get; set; }
        public string Groupnumber { get; set; }

        public TblBaseMaterialGroup FkBasematerialgroup { get; set; }
        public ICollection<TblBolting> TblBoltingFkBoltBasematerial { get; set; }
        public ICollection<TblBolting> TblBoltingFkBoltCertificate { get; set; }
        public ICollection<TblBolting> TblBoltingFkFlangeBasematerial { get; set; }
        public ICollection<TblBolting> TblBoltingFkGasketBasematerial { get; set; }
        public ICollection<TblBolting> TblBoltingFkNutBasematerial { get; set; }
        public ICollection<TblBolting> TblBoltingFkWashersBasematerial { get; set; }
        public ICollection<TblCertificate> TblCertificate { get; set; }
        public ICollection<TblMaterialLibrary> TblMaterialLibrary { get; set; }
        public ICollection<TblNdeRequest> TblNdeRequest { get; set; }
        public ICollection<TblPart> TblPart { get; set; }
        public ICollection<TblTemplateBlindPoint> TblTemplateBlindPointFkBoltBasematerial { get; set; }
        public ICollection<TblTemplateBlindPoint> TblTemplateBlindPointFkBoltCertificate { get; set; }
        public ICollection<TblTemplateBlindPoint> TblTemplateBlindPointFkFlangeBasematerial { get; set; }
        public ICollection<TblTemplateBlindPoint> TblTemplateBlindPointFkGasketBasematerial { get; set; }
        public ICollection<TblTemplateBlindPoint> TblTemplateBlindPointFkNutBasematerial { get; set; }
        public ICollection<TblTemplateBlindPoint> TblTemplateBlindPointFkWashersBasematerial { get; set; }
        public ICollection<TblWeldConnectionPart> TblWeldConnectionPart { get; set; }
        public ICollection<TblWeldProcedureQualificationRecord> TblWeldProcedureQualificationRecordFkPartabasematerial { get; set; }
        public ICollection<TblWeldProcedureQualificationRecord> TblWeldProcedureQualificationRecordFkPartbbasematerial { get; set; }
        public ICollection<TblWeldProcedureSpecification> TblWeldProcedureSpecificationFkPartabasematerial { get; set; }
        public ICollection<TblWeldProcedureSpecification> TblWeldProcedureSpecificationFkPartbbasematerial { get; set; }
    }
}

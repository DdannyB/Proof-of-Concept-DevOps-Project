using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblDn
    {
        public TblDn()
        {
            TblBlindPointActivity = new HashSet<TblBlindPointActivity>();
            TblBoltingFkAdditionalboltdiameterdn = new HashSet<TblBolting>();
            TblBoltingFkBoltdiameterdn = new HashSet<TblBolting>();
            TblBoltingFkDn = new HashSet<TblBolting>();
            TblCertificate = new HashSet<TblCertificate>();
            TblDnAlternative = new HashSet<TblDnAlternative>();
            TblMaterialLibraryFkBoltdiameterdn = new HashSet<TblMaterialLibrary>();
            TblMaterialLibraryFkDn = new HashSet<TblMaterialLibrary>();
            TblMaterialPipeSpec = new HashSet<TblMaterialPipeSpec>();
            TblNormbase = new HashSet<TblNormbase>();
            TblPart = new HashSet<TblPart>();
            TblTemplateBlindPointActivity = new HashSet<TblTemplateBlindPointActivity>();
            TblTemplateBlindPointDisciplineFkBoltdiameterdn = new HashSet<TblTemplateBlindPointDiscipline>();
            TblTemplateBlindPointDisciplineFkDn = new HashSet<TblTemplateBlindPointDiscipline>();
            TblTemplateBlindPointFkAdditionalboltdiameterdn = new HashSet<TblTemplateBlindPoint>();
            TblTemplateBlindPointFkBoltdiameterdn = new HashSet<TblTemplateBlindPoint>();
            TblTemplateBlindPointFkDn = new HashSet<TblTemplateBlindPoint>();
            TblWeldConnectionPart = new HashSet<TblWeldConnectionPart>();
            TblWeldProcedureQualificationRecordFkDnmax = new HashSet<TblWeldProcedureQualificationRecord>();
            TblWeldProcedureQualificationRecordFkDnmin = new HashSet<TblWeldProcedureQualificationRecord>();
            TblWeldProcedureSpecificationFkDnmax = new HashSet<TblWeldProcedureSpecification>();
            TblWeldProcedureSpecificationFkDnmin = new HashSet<TblWeldProcedureSpecification>();
            TblWelderQualificationRecord = new HashSet<TblWelderQualificationRecord>();
        }

        public long PkDnid { get; set; }
        public string Dndescription { get; set; }
        public decimal Dnvalue { get; set; }
        public bool Iscustom { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public int Diadntype { get; set; }

        public TblDiaDnCoupling TblDiaDnCoupling { get; set; }
        public ICollection<TblBlindPointActivity> TblBlindPointActivity { get; set; }
        public ICollection<TblBolting> TblBoltingFkAdditionalboltdiameterdn { get; set; }
        public ICollection<TblBolting> TblBoltingFkBoltdiameterdn { get; set; }
        public ICollection<TblBolting> TblBoltingFkDn { get; set; }
        public ICollection<TblCertificate> TblCertificate { get; set; }
        public ICollection<TblDnAlternative> TblDnAlternative { get; set; }
        public ICollection<TblMaterialLibrary> TblMaterialLibraryFkBoltdiameterdn { get; set; }
        public ICollection<TblMaterialLibrary> TblMaterialLibraryFkDn { get; set; }
        public ICollection<TblMaterialPipeSpec> TblMaterialPipeSpec { get; set; }
        public ICollection<TblNormbase> TblNormbase { get; set; }
        public ICollection<TblPart> TblPart { get; set; }
        public ICollection<TblTemplateBlindPointActivity> TblTemplateBlindPointActivity { get; set; }
        public ICollection<TblTemplateBlindPointDiscipline> TblTemplateBlindPointDisciplineFkBoltdiameterdn { get; set; }
        public ICollection<TblTemplateBlindPointDiscipline> TblTemplateBlindPointDisciplineFkDn { get; set; }
        public ICollection<TblTemplateBlindPoint> TblTemplateBlindPointFkAdditionalboltdiameterdn { get; set; }
        public ICollection<TblTemplateBlindPoint> TblTemplateBlindPointFkBoltdiameterdn { get; set; }
        public ICollection<TblTemplateBlindPoint> TblTemplateBlindPointFkDn { get; set; }
        public ICollection<TblWeldConnectionPart> TblWeldConnectionPart { get; set; }
        public ICollection<TblWeldProcedureQualificationRecord> TblWeldProcedureQualificationRecordFkDnmax { get; set; }
        public ICollection<TblWeldProcedureQualificationRecord> TblWeldProcedureQualificationRecordFkDnmin { get; set; }
        public ICollection<TblWeldProcedureSpecification> TblWeldProcedureSpecificationFkDnmax { get; set; }
        public ICollection<TblWeldProcedureSpecification> TblWeldProcedureSpecificationFkDnmin { get; set; }
        public ICollection<TblWelderQualificationRecord> TblWelderQualificationRecord { get; set; }
    }
}

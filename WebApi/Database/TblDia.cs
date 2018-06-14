using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblDia
    {
        public TblDia()
        {
            TblBlindPointActivity = new HashSet<TblBlindPointActivity>();
            TblBoltingFkAdditionalboltdiameterdia = new HashSet<TblBolting>();
            TblBoltingFkBoltdiameterdia = new HashSet<TblBolting>();
            TblBoltingFkDia = new HashSet<TblBolting>();
            TblCertificate = new HashSet<TblCertificate>();
            TblDiaAlternative = new HashSet<TblDiaAlternative>();
            TblDiaWthSchedCoupling = new HashSet<TblDiaWthSchedCoupling>();
            TblMaterialLibraryFkBoltdiameterdia = new HashSet<TblMaterialLibrary>();
            TblMaterialLibraryFkDia = new HashSet<TblMaterialLibrary>();
            TblMaterialPipeSpec = new HashSet<TblMaterialPipeSpec>();
            TblNormbase = new HashSet<TblNormbase>();
            TblPart = new HashSet<TblPart>();
            TblTemplateBlindPointActivity = new HashSet<TblTemplateBlindPointActivity>();
            TblTemplateBlindPointDisciplineFkBoltdiameterdia = new HashSet<TblTemplateBlindPointDiscipline>();
            TblTemplateBlindPointDisciplineFkDia = new HashSet<TblTemplateBlindPointDiscipline>();
            TblTemplateBlindPointFkAdditionalboltdiameterdia = new HashSet<TblTemplateBlindPoint>();
            TblTemplateBlindPointFkBoltdiameterdia = new HashSet<TblTemplateBlindPoint>();
            TblTemplateBlindPointFkDia = new HashSet<TblTemplateBlindPoint>();
            TblWeldConnectionPart = new HashSet<TblWeldConnectionPart>();
            TblWeldProcedureQualificationRecordFkDiamax = new HashSet<TblWeldProcedureQualificationRecord>();
            TblWeldProcedureQualificationRecordFkDiamin = new HashSet<TblWeldProcedureQualificationRecord>();
            TblWeldProcedureSpecificationFkDiamax = new HashSet<TblWeldProcedureSpecification>();
            TblWeldProcedureSpecificationFkDiamin = new HashSet<TblWeldProcedureSpecification>();
            TblWelderQualificationRecord = new HashSet<TblWelderQualificationRecord>();
        }

        public long PkDiaid { get; set; }
        public string Diadescription { get; set; }
        public decimal Diavalue { get; set; }
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
        public ICollection<TblBolting> TblBoltingFkAdditionalboltdiameterdia { get; set; }
        public ICollection<TblBolting> TblBoltingFkBoltdiameterdia { get; set; }
        public ICollection<TblBolting> TblBoltingFkDia { get; set; }
        public ICollection<TblCertificate> TblCertificate { get; set; }
        public ICollection<TblDiaAlternative> TblDiaAlternative { get; set; }
        public ICollection<TblDiaWthSchedCoupling> TblDiaWthSchedCoupling { get; set; }
        public ICollection<TblMaterialLibrary> TblMaterialLibraryFkBoltdiameterdia { get; set; }
        public ICollection<TblMaterialLibrary> TblMaterialLibraryFkDia { get; set; }
        public ICollection<TblMaterialPipeSpec> TblMaterialPipeSpec { get; set; }
        public ICollection<TblNormbase> TblNormbase { get; set; }
        public ICollection<TblPart> TblPart { get; set; }
        public ICollection<TblTemplateBlindPointActivity> TblTemplateBlindPointActivity { get; set; }
        public ICollection<TblTemplateBlindPointDiscipline> TblTemplateBlindPointDisciplineFkBoltdiameterdia { get; set; }
        public ICollection<TblTemplateBlindPointDiscipline> TblTemplateBlindPointDisciplineFkDia { get; set; }
        public ICollection<TblTemplateBlindPoint> TblTemplateBlindPointFkAdditionalboltdiameterdia { get; set; }
        public ICollection<TblTemplateBlindPoint> TblTemplateBlindPointFkBoltdiameterdia { get; set; }
        public ICollection<TblTemplateBlindPoint> TblTemplateBlindPointFkDia { get; set; }
        public ICollection<TblWeldConnectionPart> TblWeldConnectionPart { get; set; }
        public ICollection<TblWeldProcedureQualificationRecord> TblWeldProcedureQualificationRecordFkDiamax { get; set; }
        public ICollection<TblWeldProcedureQualificationRecord> TblWeldProcedureQualificationRecordFkDiamin { get; set; }
        public ICollection<TblWeldProcedureSpecification> TblWeldProcedureSpecificationFkDiamax { get; set; }
        public ICollection<TblWeldProcedureSpecification> TblWeldProcedureSpecificationFkDiamin { get; set; }
        public ICollection<TblWelderQualificationRecord> TblWelderQualificationRecord { get; set; }
    }
}

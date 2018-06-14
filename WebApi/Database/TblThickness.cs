using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblThickness
    {
        public TblThickness()
        {
            TblBlindPointActivity = new HashSet<TblBlindPointActivity>();
            TblCertificate = new HashSet<TblCertificate>();
            TblDiaWthSchedCoupling = new HashSet<TblDiaWthSchedCoupling>();
            TblMaterialLibraryFkThicknessid1Navigation = new HashSet<TblMaterialLibrary>();
            TblMaterialLibraryFkThicknessid2Navigation = new HashSet<TblMaterialLibrary>();
            TblPart = new HashSet<TblPart>();
            TblTemplateBlindPoint = new HashSet<TblTemplateBlindPoint>();
            TblTemplateBlindPointActivity = new HashSet<TblTemplateBlindPointActivity>();
            TblTemplateBlindPointDiscipline = new HashSet<TblTemplateBlindPointDiscipline>();
            TblThicknessAlternative = new HashSet<TblThicknessAlternative>();
            TblWeldConnectionPart = new HashSet<TblWeldConnectionPart>();
            TblWeldProcedureQualificationRecordFkThicknessmax = new HashSet<TblWeldProcedureQualificationRecord>();
            TblWeldProcedureQualificationRecordFkThicknessmin = new HashSet<TblWeldProcedureQualificationRecord>();
            TblWeldProcedureSpecificationFkThicknessmax = new HashSet<TblWeldProcedureSpecification>();
            TblWeldProcedureSpecificationFkThicknessmin = new HashSet<TblWeldProcedureSpecification>();
            TblWelderQualificationRecord = new HashSet<TblWelderQualificationRecord>();
        }

        public long PkThicknessid { get; set; }
        public string Thicknessdescription { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public decimal? Thicknessvalue { get; set; }
        public bool Iscustom { get; set; }

        public ICollection<TblBlindPointActivity> TblBlindPointActivity { get; set; }
        public ICollection<TblCertificate> TblCertificate { get; set; }
        public ICollection<TblDiaWthSchedCoupling> TblDiaWthSchedCoupling { get; set; }
        public ICollection<TblMaterialLibrary> TblMaterialLibraryFkThicknessid1Navigation { get; set; }
        public ICollection<TblMaterialLibrary> TblMaterialLibraryFkThicknessid2Navigation { get; set; }
        public ICollection<TblPart> TblPart { get; set; }
        public ICollection<TblTemplateBlindPoint> TblTemplateBlindPoint { get; set; }
        public ICollection<TblTemplateBlindPointActivity> TblTemplateBlindPointActivity { get; set; }
        public ICollection<TblTemplateBlindPointDiscipline> TblTemplateBlindPointDiscipline { get; set; }
        public ICollection<TblThicknessAlternative> TblThicknessAlternative { get; set; }
        public ICollection<TblWeldConnectionPart> TblWeldConnectionPart { get; set; }
        public ICollection<TblWeldProcedureQualificationRecord> TblWeldProcedureQualificationRecordFkThicknessmax { get; set; }
        public ICollection<TblWeldProcedureQualificationRecord> TblWeldProcedureQualificationRecordFkThicknessmin { get; set; }
        public ICollection<TblWeldProcedureSpecification> TblWeldProcedureSpecificationFkThicknessmax { get; set; }
        public ICollection<TblWeldProcedureSpecification> TblWeldProcedureSpecificationFkThicknessmin { get; set; }
        public ICollection<TblWelderQualificationRecord> TblWelderQualificationRecord { get; set; }
    }
}

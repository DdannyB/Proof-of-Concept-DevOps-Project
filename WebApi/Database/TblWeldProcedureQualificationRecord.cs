using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblWeldProcedureQualificationRecord
    {
        public TblWeldProcedureQualificationRecord()
        {
            TblAttachment = new HashSet<TblAttachment>();
            TblWeldProcedureQualificationRecordDocumentLabel = new HashSet<TblWeldProcedureQualificationRecordDocumentLabel>();
            TblWeldProcedureSpecification = new HashSet<TblWeldProcedureSpecification>();
            TblWelderQualification = new HashSet<TblWelderQualification>();
        }

        public long PkWeldprocedurequalificationrecordid { get; set; }
        public long? FkBranchid { get; set; }
        public string Weldprocqualrecdescription { get; set; }
        public long? FkPartabasematerialid { get; set; }
        public long? FkDiaminid { get; set; }
        public long? FkDiamaxid { get; set; }
        public long? FkDnminid { get; set; }
        public long? FkDnmaxid { get; set; }
        public long? FkThicknessminid { get; set; }
        public long? FkThicknessmaxid { get; set; }
        public long FkWeldnormid { get; set; }
        public long FkWeldprocessid { get; set; }
        public long FkWeldtypeid { get; set; }
        public long? FkWeldpositionid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long? FkFillermaterialid { get; set; }
        public long? FkWeldconsumablesid { get; set; }
        public long? FkWeldelectrodeid { get; set; }
        public long? FkPartbbasematerialid { get; set; }
        public long? FkPartbbasematerialgroupid { get; set; }
        public long? FkPartabasematerialgroupid { get; set; }
        public int? Maxheatinput { get; set; }
        public int? Maxheatinputunit { get; set; }
        public int? Interpasstemperature { get; set; }
        public int? Interpasstemperatureunit { get; set; }
        public int? Preheattemperature { get; set; }
        public int? Preheattemperatureunit { get; set; }
        public bool Isrepair { get; set; }
        public string Comment { get; set; }
        public string Approveduser { get; set; }
        public DateTime? Approveddate { get; set; }
        public long? FkContractorid { get; set; }

        public TblBranch FkBranch { get; set; }
        public TblContractor FkContractor { get; set; }
        public TblDia FkDiamax { get; set; }
        public TblDia FkDiamin { get; set; }
        public TblDn FkDnmax { get; set; }
        public TblDn FkDnmin { get; set; }
        public TblFillerMaterial FkFillermaterial { get; set; }
        public TblBaseMaterial FkPartabasematerial { get; set; }
        public TblBaseMaterialGroup FkPartabasematerialgroup { get; set; }
        public TblBaseMaterial FkPartbbasematerial { get; set; }
        public TblBaseMaterialGroup FkPartbbasematerialgroup { get; set; }
        public TblThickness FkThicknessmax { get; set; }
        public TblThickness FkThicknessmin { get; set; }
        public TblWeldConsumables FkWeldconsumables { get; set; }
        public TblWeldElectrode FkWeldelectrode { get; set; }
        public TblWeldNorm FkWeldnorm { get; set; }
        public TblWeldPosition FkWeldposition { get; set; }
        public TblWeldProcess FkWeldprocess { get; set; }
        public TblWeldType FkWeldtype { get; set; }
        public ICollection<TblAttachment> TblAttachment { get; set; }
        public ICollection<TblWeldProcedureQualificationRecordDocumentLabel> TblWeldProcedureQualificationRecordDocumentLabel { get; set; }
        public ICollection<TblWeldProcedureSpecification> TblWeldProcedureSpecification { get; set; }
        public ICollection<TblWelderQualification> TblWelderQualification { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblWeldProcedureSpecification
    {
        public TblWeldProcedureSpecification()
        {
            TblAttachment = new HashSet<TblAttachment>();
            TblWeldConnection = new HashSet<TblWeldConnection>();
            TblWeldProcedureSpecificationDocumentLabel = new HashSet<TblWeldProcedureSpecificationDocumentLabel>();
            TblWelderQualification = new HashSet<TblWelderQualification>();
        }

        public long PkWeldprocedurespecificationid { get; set; }
        public string Weldprocedurespecificationcode { get; set; }
        public string Weldprocedurespecificationdescription { get; set; }
        public long FkContractorid { get; set; }
        public long? FkWeldprocedurequalificationrecordid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long FkProjectid { get; set; }
        public string Comment { get; set; }
        public long? FkPartabasematerialid { get; set; }
        public long? FkPartabasematerialgroupid { get; set; }
        public long? FkPartbbasematerialid { get; set; }
        public long? FkPartbbasematerialgroupid { get; set; }
        public int? Maxheatinput { get; set; }
        public int? Maxheatinputunit { get; set; }
        public int? Interpasstemperature { get; set; }
        public int? Interpasstemperatureunit { get; set; }
        public int? Preheattemperature { get; set; }
        public int? Preheattemperatureunit { get; set; }
        public long? FkWeldnormid { get; set; }
        public long? FkStep1weldprocessid { get; set; }
        public long? FkWeldtypeid { get; set; }
        public long? FkWeldpositionid { get; set; }
        public long? FkStep1weldconsumablesid { get; set; }
        public long? FkWeldelectrodeid { get; set; }
        public long? FkFillermaterialid { get; set; }
        public bool? Isrepair { get; set; }
        public long? FkDiaminid { get; set; }
        public long? FkDiamaxid { get; set; }
        public long? FkDnminid { get; set; }
        public long? FkDnmaxid { get; set; }
        public long? FkThicknessminid { get; set; }
        public long? FkThicknessmaxid { get; set; }
        public DateTime? Readydate { get; set; }
        public string Readyuser { get; set; }
        public DateTime? Approveddate { get; set; }
        public string Approveduser { get; set; }
        public long? FkStep2weldprocessid { get; set; }
        public long? FkStep3weldprocessid { get; set; }
        public long? FkStep2weldconsumableid { get; set; }
        public long? FkStep3weldconsumableid { get; set; }
        public string Rev { get; set; }
        public bool Ispwht { get; set; }
        public string Pwhtspec { get; set; }
        public int? Workplaceenumvalue { get; set; }

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
        public TblProject FkProject { get; set; }
        public TblWeldConsumables FkStep1weldconsumables { get; set; }
        public TblWeldProcess FkStep1weldprocess { get; set; }
        public TblWeldConsumables FkStep2weldconsumable { get; set; }
        public TblWeldProcess FkStep2weldprocess { get; set; }
        public TblWeldConsumables FkStep3weldconsumable { get; set; }
        public TblWeldProcess FkStep3weldprocess { get; set; }
        public TblThickness FkThicknessmax { get; set; }
        public TblThickness FkThicknessmin { get; set; }
        public TblWeldElectrode FkWeldelectrode { get; set; }
        public TblWeldNorm FkWeldnorm { get; set; }
        public TblWeldPosition FkWeldposition { get; set; }
        public TblWeldProcedureQualificationRecord FkWeldprocedurequalificationrecord { get; set; }
        public TblWeldType FkWeldtype { get; set; }
        public ICollection<TblAttachment> TblAttachment { get; set; }
        public ICollection<TblWeldConnection> TblWeldConnection { get; set; }
        public ICollection<TblWeldProcedureSpecificationDocumentLabel> TblWeldProcedureSpecificationDocumentLabel { get; set; }
        public ICollection<TblWelderQualification> TblWelderQualification { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblContractor
    {
        public TblContractor()
        {
            TblBlindList = new HashSet<TblBlindList>();
            TblBlindPointActivity = new HashSet<TblBlindPointActivity>();
            TblCertificate = new HashSet<TblCertificate>();
            TblContractorField = new HashSet<TblContractorField>();
            TblExceptionContractor = new HashSet<TblExceptionContractor>();
            TblLibraryProcurementContract = new HashSet<TblLibraryProcurementContract>();
            TblLislFkMaincontractor = new HashSet<TblLisl>();
            TblLislFkNobocontractor = new HashSet<TblLisl>();
            TblMaterial = new HashSet<TblMaterial>();
            TblMaterialLibrary = new HashSet<TblMaterialLibrary>();
            TblNdeRequestFkContractor = new HashSet<TblNdeRequest>();
            TblNdeRequestFkNdecontractor = new HashSet<TblNdeRequest>();
            TblPermit = new HashSet<TblPermit>();
            TblPermitData = new HashSet<TblPermitData>();
            TblProgressResponsible = new HashSet<TblProgressResponsible>();
            TblPropackExportSent = new HashSet<TblPropackExportSent>();
            TblQuotationRequestVendor = new HashSet<TblQuotationRequestVendor>();
            TblResourceConstraint = new HashSet<TblResourceConstraint>();
            TblScope = new HashSet<TblScope>();
            TblScopeJobDetailResourceToolsAndConsumables = new HashSet<TblScopeJobDetailResourceToolsAndConsumables>();
            TblScopePunchlist = new HashSet<TblScopePunchlist>();
            TblScopeQaqcQuicklist = new HashSet<TblScopeQaqcQuicklist>();
            TblScopeSubDiscipline = new HashSet<TblScopeSubDiscipline>();
            TblTemplateBlindPointDiscipline = new HashSet<TblTemplateBlindPointDiscipline>();
            TblTestSystem = new HashSet<TblTestSystem>();
            TblTimeKeepingMileageType = new HashSet<TblTimeKeepingMileageType>();
            TblTimekeepingEntryType = new HashSet<TblTimekeepingEntryType>();
            TblToolsAndConsumables = new HashSet<TblToolsAndConsumables>();
            TblUserFkContractor = new HashSet<TblUser>();
            TblUserFkSubcontractor = new HashSet<TblUser>();
            TblUserMemberContractor = new HashSet<TblUserMemberContractor>();
            TblWeldProcedureQualificationRecord = new HashSet<TblWeldProcedureQualificationRecord>();
            TblWeldProcedureSpecification = new HashSet<TblWeldProcedureSpecification>();
            TblWelderFkContractor = new HashSet<TblWelder>();
            TblWelderFkSubcontractor = new HashSet<TblWelder>();
        }

        public long PkContractorid { get; set; }
        public string Contractorname { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public string Accountnr { get; set; }
        public string Contractornr { get; set; }
        public string Contactperson { get; set; }
        public string Street { get; set; }
        public string Zipcode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public bool Iswelditcontractor { get; set; }
        public byte[] Contractorlogo { get; set; }
        public int Contractorcolor { get; set; }
        public bool Iscontractor { get; set; }
        public bool Isvendor { get; set; }
        public bool Isndecompany { get; set; }
        public long? FkCalendarid { get; set; }
        public bool Isnobo { get; set; }

        public TblCalendar FkCalendar { get; set; }
        public ICollection<TblBlindList> TblBlindList { get; set; }
        public ICollection<TblBlindPointActivity> TblBlindPointActivity { get; set; }
        public ICollection<TblCertificate> TblCertificate { get; set; }
        public ICollection<TblContractorField> TblContractorField { get; set; }
        public ICollection<TblExceptionContractor> TblExceptionContractor { get; set; }
        public ICollection<TblLibraryProcurementContract> TblLibraryProcurementContract { get; set; }
        public ICollection<TblLisl> TblLislFkMaincontractor { get; set; }
        public ICollection<TblLisl> TblLislFkNobocontractor { get; set; }
        public ICollection<TblMaterial> TblMaterial { get; set; }
        public ICollection<TblMaterialLibrary> TblMaterialLibrary { get; set; }
        public ICollection<TblNdeRequest> TblNdeRequestFkContractor { get; set; }
        public ICollection<TblNdeRequest> TblNdeRequestFkNdecontractor { get; set; }
        public ICollection<TblPermit> TblPermit { get; set; }
        public ICollection<TblPermitData> TblPermitData { get; set; }
        public ICollection<TblProgressResponsible> TblProgressResponsible { get; set; }
        public ICollection<TblPropackExportSent> TblPropackExportSent { get; set; }
        public ICollection<TblQuotationRequestVendor> TblQuotationRequestVendor { get; set; }
        public ICollection<TblResourceConstraint> TblResourceConstraint { get; set; }
        public ICollection<TblScope> TblScope { get; set; }
        public ICollection<TblScopeJobDetailResourceToolsAndConsumables> TblScopeJobDetailResourceToolsAndConsumables { get; set; }
        public ICollection<TblScopePunchlist> TblScopePunchlist { get; set; }
        public ICollection<TblScopeQaqcQuicklist> TblScopeQaqcQuicklist { get; set; }
        public ICollection<TblScopeSubDiscipline> TblScopeSubDiscipline { get; set; }
        public ICollection<TblTemplateBlindPointDiscipline> TblTemplateBlindPointDiscipline { get; set; }
        public ICollection<TblTestSystem> TblTestSystem { get; set; }
        public ICollection<TblTimeKeepingMileageType> TblTimeKeepingMileageType { get; set; }
        public ICollection<TblTimekeepingEntryType> TblTimekeepingEntryType { get; set; }
        public ICollection<TblToolsAndConsumables> TblToolsAndConsumables { get; set; }
        public ICollection<TblUser> TblUserFkContractor { get; set; }
        public ICollection<TblUser> TblUserFkSubcontractor { get; set; }
        public ICollection<TblUserMemberContractor> TblUserMemberContractor { get; set; }
        public ICollection<TblWeldProcedureQualificationRecord> TblWeldProcedureQualificationRecord { get; set; }
        public ICollection<TblWeldProcedureSpecification> TblWeldProcedureSpecification { get; set; }
        public ICollection<TblWelder> TblWelderFkContractor { get; set; }
        public ICollection<TblWelder> TblWelderFkSubcontractor { get; set; }
    }
}

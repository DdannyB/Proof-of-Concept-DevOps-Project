using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblSubDiscipline
    {
        public TblSubDiscipline()
        {
            TblBlindListReportColumn = new HashSet<TblBlindListReportColumn>();
            TblBudgetTemplateSubDiscipline = new HashSet<TblBudgetTemplateSubDiscipline>();
            TblDisciplineCode = new HashSet<TblDisciplineCode>();
            TblDisciplineType = new HashSet<TblDisciplineType>();
            TblDocumentLabelShortcodeSubDiscipline = new HashSet<TblDocumentLabelShortcodeSubDiscipline>();
            TblJobData = new HashSet<TblJobData>();
            TblLibraryProcurementContract = new HashSet<TblLibraryProcurementContract>();
            TblPermitData = new HashSet<TblPermitData>();
            TblQaqcQuicklist = new HashSet<TblQaqcQuicklist>();
            TblRate = new HashSet<TblRate>();
            TblResource = new HashSet<TblResource>();
            TblScopeSubDiscipline = new HashSet<TblScopeSubDiscipline>();
            TblTemplateBlindPointDiscipline = new HashSet<TblTemplateBlindPointDiscipline>();
            TblUserMemberDiscipline = new HashSet<TblUserMemberDiscipline>();
        }

        public long PkSubdisciplineid { get; set; }
        public long FkMaindisciplineid { get; set; }
        public string Subdisciplinecode { get; set; }
        public string SubdisciplinedescriptionL1 { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public string Normbasetype { get; set; }
        public string SubdisciplinedescriptionL2 { get; set; }
        public string SubdisciplinedescriptionL3 { get; set; }
        public string SubdisciplinedescriptionL4 { get; set; }
        public string SubdisciplinedescriptionL5 { get; set; }

        public TblMainDiscipline FkMaindiscipline { get; set; }
        public ICollection<TblBlindListReportColumn> TblBlindListReportColumn { get; set; }
        public ICollection<TblBudgetTemplateSubDiscipline> TblBudgetTemplateSubDiscipline { get; set; }
        public ICollection<TblDisciplineCode> TblDisciplineCode { get; set; }
        public ICollection<TblDisciplineType> TblDisciplineType { get; set; }
        public ICollection<TblDocumentLabelShortcodeSubDiscipline> TblDocumentLabelShortcodeSubDiscipline { get; set; }
        public ICollection<TblJobData> TblJobData { get; set; }
        public ICollection<TblLibraryProcurementContract> TblLibraryProcurementContract { get; set; }
        public ICollection<TblPermitData> TblPermitData { get; set; }
        public ICollection<TblQaqcQuicklist> TblQaqcQuicklist { get; set; }
        public ICollection<TblRate> TblRate { get; set; }
        public ICollection<TblResource> TblResource { get; set; }
        public ICollection<TblScopeSubDiscipline> TblScopeSubDiscipline { get; set; }
        public ICollection<TblTemplateBlindPointDiscipline> TblTemplateBlindPointDiscipline { get; set; }
        public ICollection<TblUserMemberDiscipline> TblUserMemberDiscipline { get; set; }
    }
}

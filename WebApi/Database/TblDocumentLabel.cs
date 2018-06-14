using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblDocumentLabel
    {
        public TblDocumentLabel()
        {
            TblAttachment = new HashSet<TblAttachment>();
            TblBasePermitItemPartDocumentLabel = new HashSet<TblBasePermitItemPartDocumentLabel>();
            TblBlindListDocumentLabel = new HashSet<TblBlindListDocumentLabel>();
            TblBlindPointDocumentLabel = new HashSet<TblBlindPointDocumentLabel>();
            TblCertificateDocumentLabel = new HashSet<TblCertificateDocumentLabel>();
            TblChangeRequestDocumentLabel = new HashSet<TblChangeRequestDocumentLabel>();
            TblDefaultAttachment = new HashSet<TblDefaultAttachment>();
            TblDocumentLabelDefault = new HashSet<TblDocumentLabelDefault>();
            TblDocumentLabelShortcodeSubDiscipline = new HashSet<TblDocumentLabelShortcodeSubDiscipline>();
            TblLislDocumentLabel = new HashSet<TblLislDocumentLabel>();
            TblNdeMain = new HashSet<TblNdeMain>();
            TblNdeRequestDocumentLabel = new HashSet<TblNdeRequestDocumentLabel>();
            TblNdeSub = new HashSet<TblNdeSub>();
            TblPermitDocumentLabel = new HashSet<TblPermitDocumentLabel>();
            TblPlantDataDocumentLabel = new HashSet<TblPlantDataDocumentLabel>();
            TblPrintTemplateDetail = new HashSet<TblPrintTemplateDetail>();
            TblScopeDocumentLabel = new HashSet<TblScopeDocumentLabel>();
            TblScopePunchlistDocumentLabel = new HashSet<TblScopePunchlistDocumentLabel>();
            TblTemplateBlindPointDocumentLabel = new HashSet<TblTemplateBlindPointDocumentLabel>();
            TblWeldProcedureDocumentLabel = new HashSet<TblWeldProcedureDocumentLabel>();
            TblWeldProcedureQualificationRecordDocumentLabel = new HashSet<TblWeldProcedureQualificationRecordDocumentLabel>();
            TblWeldProcedureSpecificationDocumentLabel = new HashSet<TblWeldProcedureSpecificationDocumentLabel>();
            TblWelderQualificationDocumentLabel = new HashSet<TblWelderQualificationDocumentLabel>();
        }

        public long PkDocumentlabelid { get; set; }
        public long? FkDocumentlabelgroupid { get; set; }
        public string Documentlabelcode { get; set; }
        public string Documentlabeldescription { get; set; }
        public bool Scopeitrequestdocumentlabel { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public bool Welditrequestdocumentlabel { get; set; }
        public bool Blinditdocumentlabel { get; set; }
        public bool Permititdocumentlabel { get; set; }
        public bool Changeitdocumentlabel { get; set; }

        public TblDocumentLabelGroup FkDocumentlabelgroup { get; set; }
        public ICollection<TblAttachment> TblAttachment { get; set; }
        public ICollection<TblBasePermitItemPartDocumentLabel> TblBasePermitItemPartDocumentLabel { get; set; }
        public ICollection<TblBlindListDocumentLabel> TblBlindListDocumentLabel { get; set; }
        public ICollection<TblBlindPointDocumentLabel> TblBlindPointDocumentLabel { get; set; }
        public ICollection<TblCertificateDocumentLabel> TblCertificateDocumentLabel { get; set; }
        public ICollection<TblChangeRequestDocumentLabel> TblChangeRequestDocumentLabel { get; set; }
        public ICollection<TblDefaultAttachment> TblDefaultAttachment { get; set; }
        public ICollection<TblDocumentLabelDefault> TblDocumentLabelDefault { get; set; }
        public ICollection<TblDocumentLabelShortcodeSubDiscipline> TblDocumentLabelShortcodeSubDiscipline { get; set; }
        public ICollection<TblLislDocumentLabel> TblLislDocumentLabel { get; set; }
        public ICollection<TblNdeMain> TblNdeMain { get; set; }
        public ICollection<TblNdeRequestDocumentLabel> TblNdeRequestDocumentLabel { get; set; }
        public ICollection<TblNdeSub> TblNdeSub { get; set; }
        public ICollection<TblPermitDocumentLabel> TblPermitDocumentLabel { get; set; }
        public ICollection<TblPlantDataDocumentLabel> TblPlantDataDocumentLabel { get; set; }
        public ICollection<TblPrintTemplateDetail> TblPrintTemplateDetail { get; set; }
        public ICollection<TblScopeDocumentLabel> TblScopeDocumentLabel { get; set; }
        public ICollection<TblScopePunchlistDocumentLabel> TblScopePunchlistDocumentLabel { get; set; }
        public ICollection<TblTemplateBlindPointDocumentLabel> TblTemplateBlindPointDocumentLabel { get; set; }
        public ICollection<TblWeldProcedureDocumentLabel> TblWeldProcedureDocumentLabel { get; set; }
        public ICollection<TblWeldProcedureQualificationRecordDocumentLabel> TblWeldProcedureQualificationRecordDocumentLabel { get; set; }
        public ICollection<TblWeldProcedureSpecificationDocumentLabel> TblWeldProcedureSpecificationDocumentLabel { get; set; }
        public ICollection<TblWelderQualificationDocumentLabel> TblWelderQualificationDocumentLabel { get; set; }
    }
}

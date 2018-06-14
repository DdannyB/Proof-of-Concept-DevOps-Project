using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblAttachment
    {
        public long PkAttachmentid { get; set; }
        public string Description { get; set; }
        public bool? Isdefault { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long? FkBlindpointid { get; set; }
        public string Filepath { get; set; }
        public long? FkTemplateblindpointid { get; set; }
        public long? FkLislid { get; set; }
        public long? FkNderequestid { get; set; }
        public long? FkWeldprocedureid { get; set; }
        public long? FkCertificateid { get; set; }
        public long? FkPlantdataid { get; set; }
        public long FkDocumentlabelid { get; set; }
        public bool Isweblink { get; set; }
        public long? FkScopeid { get; set; }
        public long? FkBasepermititempartid { get; set; }
        public long? FkWeldprocedurequalificationrecordid { get; set; }
        public long? FkBlindlistid { get; set; }
        public long? FkPermitid { get; set; }
        public long? FkWeldprocedurespecificationid { get; set; }
        public long? FkWelderqualificationid { get; set; }
        public long? FkActivechangerequestid { get; set; }
        public long? FkDocumentitemid { get; set; }
        public long? FkScopepunchlistid { get; set; }
        public long? FkPidrevisionid { get; set; }
        public byte[] Thumbnail { get; set; }
        public DateTime? Thumbnaillastmodified { get; set; }
        public int? Attachmenttype { get; set; }
        public long? Attachmenttypeid { get; set; }

        public TblActiveChangeRequest FkActivechangerequest { get; set; }
        public TblBasePermitItemPart FkBasepermititempart { get; set; }
        public TblBlindList FkBlindlist { get; set; }
        public TblBlindPoint FkBlindpoint { get; set; }
        public TblCertificate FkCertificate { get; set; }
        public TblDocumentItem FkDocumentitem { get; set; }
        public TblDocumentLabel FkDocumentlabel { get; set; }
        public TblLisl FkLisl { get; set; }
        public TblNdeRequest FkNderequest { get; set; }
        public TblPermit FkPermit { get; set; }
        public TblPidRevision FkPidrevision { get; set; }
        public TblPlantData FkPlantdata { get; set; }
        public TblScope FkScope { get; set; }
        public TblScopePunchlist FkScopepunchlist { get; set; }
        public TblTemplateBlindPoint FkTemplateblindpoint { get; set; }
        public TblWelderQualification FkWelderqualification { get; set; }
        public TblWeldProcedure FkWeldprocedure { get; set; }
        public TblWeldProcedureQualificationRecord FkWeldprocedurequalificationrecord { get; set; }
        public TblWeldProcedureSpecification FkWeldprocedurespecification { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblActiveChangeRequest
    {
        public TblActiveChangeRequest()
        {
            TblAttachment = new HashSet<TblAttachment>();
            TblAudit = new HashSet<TblAudit>();
            TblChangeRequestComplexityItem = new HashSet<TblChangeRequestComplexityItem>();
            TblChangeRequestDocumentLabel = new HashSet<TblChangeRequestDocumentLabel>();
            TblChangeRequestFormulaParameter = new HashSet<TblChangeRequestFormulaParameter>();
            TblChangeRequestLabel = new HashSet<TblChangeRequestLabel>();
            TblChangeRequestLog = new HashSet<TblChangeRequestLog>();
            TblChangeRequestWorkflowState = new HashSet<TblChangeRequestWorkflowState>();
        }

        public long PkActivechangerequestid { get; set; }
        public long? FkChangerequestid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblChangeRequest FkChangerequest { get; set; }
        public ICollection<TblAttachment> TblAttachment { get; set; }
        public ICollection<TblAudit> TblAudit { get; set; }
        public ICollection<TblChangeRequestComplexityItem> TblChangeRequestComplexityItem { get; set; }
        public ICollection<TblChangeRequestDocumentLabel> TblChangeRequestDocumentLabel { get; set; }
        public ICollection<TblChangeRequestFormulaParameter> TblChangeRequestFormulaParameter { get; set; }
        public ICollection<TblChangeRequestLabel> TblChangeRequestLabel { get; set; }
        public ICollection<TblChangeRequestLog> TblChangeRequestLog { get; set; }
        public ICollection<TblChangeRequestWorkflowState> TblChangeRequestWorkflowState { get; set; }
    }
}

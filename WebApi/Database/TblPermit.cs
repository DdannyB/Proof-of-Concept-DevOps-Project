using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblPermit
    {
        public TblPermit()
        {
            TblAttachment = new HashSet<TblAttachment>();
            TblPermitData = new HashSet<TblPermitData>();
            TblPermitDocumentLabel = new HashSet<TblPermitDocumentLabel>();
            TblPermitItemPart = new HashSet<TblPermitItemPart>();
            TblPermitLog = new HashSet<TblPermitLog>();
            TblPermitMessage = new HashSet<TblPermitMessage>();
            TblPermitWorkflowState = new HashSet<TblPermitWorkflowState>();
            TblReleaseForPermit = new HashSet<TblReleaseForPermit>();
            TblScopeJobPermit = new HashSet<TblScopeJobPermit>();
        }

        public long PkPermitid { get; set; }
        public int Permitnumber { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long FkBasepermitid { get; set; }
        public short? Issuecount { get; set; }
        public string Permitjobdescription { get; set; }
        public string Permitjobmemo { get; set; }
        public int? Permitrevisionnr { get; set; }
        public long? FkContractorid { get; set; }
        public int? Permitclustertype { get; set; }
        public long FkProjectid { get; set; }
        public short Indexlistrevision { get; set; }
        public long? FkArchivecodeid { get; set; }
        public string Archivecodechangeduser { get; set; }
        public DateTime? Archivecodechangeddate { get; set; }
        public string Permitscopememo { get; set; }
        public string Permitschedulermemo { get; set; }
        public string Permitjobdetailmemo { get; set; }
        public string Permitresourcememo { get; set; }
        public long FkCurrentworkflowstateid { get; set; }

        public TblArchiveCode FkArchivecode { get; set; }
        public TblBasePermit FkBasepermit { get; set; }
        public TblContractor FkContractor { get; set; }
        public TblWorkflowState FkCurrentworkflowstate { get; set; }
        public TblProject FkProject { get; set; }
        public ICollection<TblAttachment> TblAttachment { get; set; }
        public ICollection<TblPermitData> TblPermitData { get; set; }
        public ICollection<TblPermitDocumentLabel> TblPermitDocumentLabel { get; set; }
        public ICollection<TblPermitItemPart> TblPermitItemPart { get; set; }
        public ICollection<TblPermitLog> TblPermitLog { get; set; }
        public ICollection<TblPermitMessage> TblPermitMessage { get; set; }
        public ICollection<TblPermitWorkflowState> TblPermitWorkflowState { get; set; }
        public ICollection<TblReleaseForPermit> TblReleaseForPermit { get; set; }
        public ICollection<TblScopeJobPermit> TblScopeJobPermit { get; set; }
    }
}

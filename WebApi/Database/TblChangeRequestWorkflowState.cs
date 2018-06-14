using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblChangeRequestWorkflowState
    {
        public long PkChangerequestworkflowstateid { get; set; }
        public long FkActivechangerequestid { get; set; }
        public long FkWorkflowstateid { get; set; }
        public long? FkEntryworkflowstatetransitionid { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public bool Signed { get; set; }
        public string Signedcomputer { get; set; }
        public string Signeduser { get; set; }
        public DateTime? Signeddate { get; set; }
        public string Memo { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblActiveChangeRequest FkActivechangerequest { get; set; }
        public TblWorkflowStateTransition FkEntryworkflowstatetransition { get; set; }
        public TblWorkflowState FkWorkflowstate { get; set; }
    }
}

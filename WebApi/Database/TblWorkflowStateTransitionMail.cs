using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblWorkflowStateTransitionMail
    {
        public TblWorkflowStateTransitionMail()
        {
            TblWorkflowStateTransitionMailRecipient = new HashSet<TblWorkflowStateTransitionMailRecipient>();
        }

        public long PkWorkflowstatetransitionmailid { get; set; }
        public long FkWorkflowstatetransitionid { get; set; }
        public long FkMailid { get; set; }
        public int Mailrecipients { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblMail FkMail { get; set; }
        public TblWorkflowStateTransition FkWorkflowstatetransition { get; set; }
        public ICollection<TblWorkflowStateTransitionMailRecipient> TblWorkflowStateTransitionMailRecipient { get; set; }
    }
}

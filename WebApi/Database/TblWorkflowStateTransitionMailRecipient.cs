using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblWorkflowStateTransitionMailRecipient
    {
        public long PkWorkflowstatetransitionmailrecipientid { get; set; }
        public long FkWorkflowstatetransitionmailid { get; set; }
        public long FkRoleid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblRole FkRole { get; set; }
        public TblWorkflowStateTransitionMail FkWorkflowstatetransitionmail { get; set; }
    }
}

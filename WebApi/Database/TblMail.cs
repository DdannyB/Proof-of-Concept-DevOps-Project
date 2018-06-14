using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblMail
    {
        public TblMail()
        {
            TblWorkflowStateTransition = new HashSet<TblWorkflowStateTransition>();
            TblWorkflowStateTransitionMail = new HashSet<TblWorkflowStateTransitionMail>();
        }

        public long PkMailid { get; set; }
        public string Mailname { get; set; }
        public string Mailsubject { get; set; }
        public string Mailbody { get; set; }
        public bool Systemmail { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public ICollection<TblWorkflowStateTransition> TblWorkflowStateTransition { get; set; }
        public ICollection<TblWorkflowStateTransitionMail> TblWorkflowStateTransitionMail { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblRole
    {
        public TblRole()
        {
            TblRoleRight = new HashSet<TblRoleRight>();
            TblUserApplicationProjectRole = new HashSet<TblUserApplicationProjectRole>();
            TblWorkflowStateRightRestriction = new HashSet<TblWorkflowStateRightRestriction>();
            TblWorkflowStateTransitionMailRecipient = new HashSet<TblWorkflowStateTransitionMailRecipient>();
            TblWorkflowStateTransitionRole = new HashSet<TblWorkflowStateTransitionRole>();
        }

        public long PkRoleid { get; set; }
        public long FkApplicationid { get; set; }
        public string Name { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public int? Sortorder { get; set; }

        public TblApplication FkApplication { get; set; }
        public ICollection<TblRoleRight> TblRoleRight { get; set; }
        public ICollection<TblUserApplicationProjectRole> TblUserApplicationProjectRole { get; set; }
        public ICollection<TblWorkflowStateRightRestriction> TblWorkflowStateRightRestriction { get; set; }
        public ICollection<TblWorkflowStateTransitionMailRecipient> TblWorkflowStateTransitionMailRecipient { get; set; }
        public ICollection<TblWorkflowStateTransitionRole> TblWorkflowStateTransitionRole { get; set; }
    }
}

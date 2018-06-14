using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblRight
    {
        public TblRight()
        {
            TblProcessAreaRestrictedRight = new HashSet<TblProcessAreaRestrictedRight>();
            TblRoleRight = new HashSet<TblRoleRight>();
            TblUserApplicationProjectRight = new HashSet<TblUserApplicationProjectRight>();
            TblWorkflowStateRightRestriction = new HashSet<TblWorkflowStateRightRestriction>();
        }

        public long PkRightid { get; set; }
        public long FkRightfunctionid { get; set; }
        public long FkRightpermissionid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblRightFunction FkRightfunction { get; set; }
        public TblRightPermission FkRightpermission { get; set; }
        public ICollection<TblProcessAreaRestrictedRight> TblProcessAreaRestrictedRight { get; set; }
        public ICollection<TblRoleRight> TblRoleRight { get; set; }
        public ICollection<TblUserApplicationProjectRight> TblUserApplicationProjectRight { get; set; }
        public ICollection<TblWorkflowStateRightRestriction> TblWorkflowStateRightRestriction { get; set; }
    }
}

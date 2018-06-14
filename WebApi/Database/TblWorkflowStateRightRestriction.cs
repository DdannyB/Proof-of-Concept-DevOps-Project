using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblWorkflowStateRightRestriction
    {
        public long PkWorkflowstaterightrestrictionid { get; set; }
        public long FkWorkflowstateid { get; set; }
        public long FkRightid { get; set; }
        public long? FkRoleid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public bool Isrestricted { get; set; }

        public TblRight FkRight { get; set; }
        public TblRole FkRole { get; set; }
        public TblWorkflowState FkWorkflowstate { get; set; }
    }
}

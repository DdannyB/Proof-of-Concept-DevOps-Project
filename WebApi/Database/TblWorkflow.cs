using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblWorkflow
    {
        public TblWorkflow()
        {
            TblBasePermit = new HashSet<TblBasePermit>();
            TblChangeRequest = new HashSet<TblChangeRequest>();
            TblProjectWorkflow = new HashSet<TblProjectWorkflow>();
            TblWorkflowState = new HashSet<TblWorkflowState>();
        }

        public long PkWorkflowid { get; set; }
        public long FkApplicationid { get; set; }
        public string Workflowname { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public bool Isdefault { get; set; }
        public DateTime? Freezedate { get; set; }
        public DateTime? Inactivedate { get; set; }
        public int? Revisionnr { get; set; }
        public long Workflownr { get; set; }
        public int? Workflowtype { get; set; }

        public TblApplication FkApplication { get; set; }
        public ICollection<TblBasePermit> TblBasePermit { get; set; }
        public ICollection<TblChangeRequest> TblChangeRequest { get; set; }
        public ICollection<TblProjectWorkflow> TblProjectWorkflow { get; set; }
        public ICollection<TblWorkflowState> TblWorkflowState { get; set; }
    }
}

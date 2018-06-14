using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblDrawingLayout
    {
        public long PkDrawinglayoutid { get; set; }
        public long? FkWorkflowstateid { get; set; }
        public long? FkWorkflowstatetransitionid { get; set; }
        public int Locationx { get; set; }
        public int Locationy { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblWorkflowState FkWorkflowstate { get; set; }
        public TblWorkflowStateTransition FkWorkflowstatetransition { get; set; }
    }
}

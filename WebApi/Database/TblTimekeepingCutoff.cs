using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblTimekeepingCutoff
    {
        public long PkTimekeepingcutoffid { get; set; }
        public long FkWorkflowstatetransitionid { get; set; }
        public int Frequencyenumvalue { get; set; }
        public int Frequencytimes { get; set; }
        public int Businessdaysafter { get; set; }
        public int Hoursbefore { get; set; }
        public int Minutesbefore { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblWorkflowStateTransition FkWorkflowstatetransition { get; set; }
    }
}

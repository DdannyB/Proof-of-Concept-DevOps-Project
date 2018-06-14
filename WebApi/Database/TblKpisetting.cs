using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblKpisetting
    {
        public long PkKpisettingid { get; set; }
        public long? FkStartworkflowstateid { get; set; }
        public long? FkEndworkflowstateid { get; set; }
        public string Settingdescription { get; set; }
        public int Settingvalueyellow { get; set; }
        public int Settingvaluered { get; set; }
        public int? Kpitype { get; set; }
        public int? Kpimeasurevalue { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblWorkflowState FkEndworkflowstate { get; set; }
        public TblWorkflowState FkStartworkflowstate { get; set; }
    }
}

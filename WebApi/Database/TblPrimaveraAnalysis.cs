using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblPrimaveraAnalysis
    {
        public long PkPrimaveraanalysis { get; set; }
        public long FkProjectid { get; set; }
        public int? Oldid { get; set; }
        public string Olddb { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public string Activityid { get; set; }
        public string Description { get; set; }
        public decimal? Originalduration { get; set; }
        public string Calendarid { get; set; }
        public string Resourcename { get; set; }
        public string Costaccountcode { get; set; }
        public decimal? Budgetquantity { get; set; }
        public string Primaveraversion { get; set; }

        public TblProject FkProject { get; set; }
    }
}

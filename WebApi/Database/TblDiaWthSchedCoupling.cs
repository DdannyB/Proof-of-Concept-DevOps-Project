using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblDiaWthSchedCoupling
    {
        public long PkDiawthschedcouplingid { get; set; }
        public long FkDiaid { get; set; }
        public long FkThicknessid { get; set; }
        public long FkScheduleid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblDia FkDia { get; set; }
        public TblSchedule FkSchedule { get; set; }
        public TblThickness FkThickness { get; set; }
    }
}

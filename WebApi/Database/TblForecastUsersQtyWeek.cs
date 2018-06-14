using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblForecastUsersQtyWeek
    {
        public long PkForecastusersqtyweekid { get; set; }
        public long FkUserid { get; set; }
        public long FkWorkpreparationphaseid { get; set; }
        public long FkProjectid { get; set; }
        public int? Oldid { get; set; }
        public string Olddb { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public int Qty { get; set; }
        public DateTime Yearweekdate { get; set; }

        public TblProject FkProject { get; set; }
        public TblUser FkUser { get; set; }
        public TblWorkPreparationPhase FkWorkpreparationphase { get; set; }
    }
}

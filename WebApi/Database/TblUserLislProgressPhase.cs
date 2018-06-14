using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblUserLislProgressPhase
    {
        public long PkUserlislprogressphaseid { get; set; }
        public long FkUserid { get; set; }
        public long FkProjectid { get; set; }
        public long FkLislprogressphaseid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblLislProgressPhase FkLislprogressphase { get; set; }
        public TblProject FkProject { get; set; }
        public TblUser FkUser { get; set; }
    }
}

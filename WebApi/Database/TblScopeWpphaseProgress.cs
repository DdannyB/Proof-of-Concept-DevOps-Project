using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblScopeWpphaseProgress
    {
        public long PkScopewpphaseprogressid { get; set; }
        public long FkScopeid { get; set; }
        public long FkWorkpreparationphaseid { get; set; }
        public int? Oldid { get; set; }
        public string Olddb { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public DateTime? Readydate { get; set; }
        public string Readyuser { get; set; }

        public TblScope FkScope { get; set; }
        public TblWorkPreparationPhase FkWorkpreparationphase { get; set; }
    }
}

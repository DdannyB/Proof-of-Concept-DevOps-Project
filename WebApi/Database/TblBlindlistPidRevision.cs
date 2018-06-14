using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblBlindlistPidRevision
    {
        public TblBlindlistPidRevision()
        {
            TblBlindListPidRevisionPageView = new HashSet<TblBlindListPidRevisionPageView>();
        }

        public long PkBlindlistpidrevisionid { get; set; }
        public long FkBlindlistid { get; set; }
        public long FkPidrevisionid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblBlindList FkBlindlist { get; set; }
        public TblPidRevision FkPidrevision { get; set; }
        public ICollection<TblBlindListPidRevisionPageView> TblBlindListPidRevisionPageView { get; set; }
    }
}

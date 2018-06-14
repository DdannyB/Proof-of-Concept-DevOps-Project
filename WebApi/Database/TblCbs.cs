using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblCbs
    {
        public TblCbs()
        {
            InverseFkCbsparent = new HashSet<TblCbs>();
            TblMilestone = new HashSet<TblMilestone>();
            TblPermitData = new HashSet<TblPermitData>();
            TblScope = new HashSet<TblScope>();
        }

        public long PkCbsid { get; set; }
        public long FkProjectid { get; set; }
        public long? FkCbsparentid { get; set; }
        public string Cbsnr { get; set; }
        public string Cbsname { get; set; }
        public string Cbsdescription { get; set; }
        public string Exportcode { get; set; }
        public string Cbssortorder { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblCbs FkCbsparent { get; set; }
        public TblProject FkProject { get; set; }
        public ICollection<TblCbs> InverseFkCbsparent { get; set; }
        public ICollection<TblMilestone> TblMilestone { get; set; }
        public ICollection<TblPermitData> TblPermitData { get; set; }
        public ICollection<TblScope> TblScope { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblObs
    {
        public TblObs()
        {
            InverseFkObsparent = new HashSet<TblObs>();
            TblMilestone = new HashSet<TblMilestone>();
            TblPermitData = new HashSet<TblPermitData>();
            TblProgressResponsible = new HashSet<TblProgressResponsible>();
            TblScope = new HashSet<TblScope>();
        }

        public long PkObsid { get; set; }
        public long FkProjectid { get; set; }
        public long? FkObsparentid { get; set; }
        public string Obsnr { get; set; }
        public string Obsname { get; set; }
        public string Obsdescription { get; set; }
        public string Exportcode { get; set; }
        public string Obssortorder { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblObs FkObsparent { get; set; }
        public TblProject FkProject { get; set; }
        public ICollection<TblObs> InverseFkObsparent { get; set; }
        public ICollection<TblMilestone> TblMilestone { get; set; }
        public ICollection<TblPermitData> TblPermitData { get; set; }
        public ICollection<TblProgressResponsible> TblProgressResponsible { get; set; }
        public ICollection<TblScope> TblScope { get; set; }
    }
}

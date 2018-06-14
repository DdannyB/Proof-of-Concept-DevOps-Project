using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblWbs
    {
        public TblWbs()
        {
            InverseFkWbsparent = new HashSet<TblWbs>();
            TblMilestone = new HashSet<TblMilestone>();
            TblPermitData = new HashSet<TblPermitData>();
            TblProgressResponsible = new HashSet<TblProgressResponsible>();
            TblScope = new HashSet<TblScope>();
        }

        public long PkWbsid { get; set; }
        public long FkProjectid { get; set; }
        public long? FkWbsparentid { get; set; }
        public string Wbsnr { get; set; }
        public string Wbsname { get; set; }
        public string Wbsdescription { get; set; }
        public string Exportcode { get; set; }
        public string Wbssortorder { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblProject FkProject { get; set; }
        public TblWbs FkWbsparent { get; set; }
        public ICollection<TblWbs> InverseFkWbsparent { get; set; }
        public ICollection<TblMilestone> TblMilestone { get; set; }
        public ICollection<TblPermitData> TblPermitData { get; set; }
        public ICollection<TblProgressResponsible> TblProgressResponsible { get; set; }
        public ICollection<TblScope> TblScope { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblPermitHorizontalClusterStrategyFilter
    {
        public long PkPermithorizontalclusterstrategyfilterid { get; set; }
        public long FkPermithorizontalclusterstrategyid { get; set; }
        public int Strategyfiltertype { get; set; }
        public string Filter { get; set; }
        public string Visualfilter { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblPermitHorizontalClusterStrategy FkPermithorizontalclusterstrategy { get; set; }
    }
}

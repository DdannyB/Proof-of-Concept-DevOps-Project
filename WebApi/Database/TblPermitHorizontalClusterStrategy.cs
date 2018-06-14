using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblPermitHorizontalClusterStrategy
    {
        public TblPermitHorizontalClusterStrategy()
        {
            TblPermitHorizontalClusterStrategyFilter = new HashSet<TblPermitHorizontalClusterStrategyFilter>();
        }

        public long PkPermithorizontalclusterstrategyid { get; set; }
        public long FkStrategyuserid { get; set; }
        public string Strategyname { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public DateTime? Freezedate { get; set; }
        public string Freezeuser { get; set; }

        public TblUser FkStrategyuser { get; set; }
        public ICollection<TblPermitHorizontalClusterStrategyFilter> TblPermitHorizontalClusterStrategyFilter { get; set; }
    }
}

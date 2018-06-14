using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblDecisionItem
    {
        public TblDecisionItem()
        {
            TblScope = new HashSet<TblScope>();
        }

        public long PkDecisionitemid { get; set; }
        public string Decisionitemdescription { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public ICollection<TblScope> TblScope { get; set; }
    }
}

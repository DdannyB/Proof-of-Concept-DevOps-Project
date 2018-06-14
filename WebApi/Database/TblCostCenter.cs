using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblCostCenter
    {
        public TblCostCenter()
        {
            TblResource = new HashSet<TblResource>();
            TblScopeJobDetailResource = new HashSet<TblScopeJobDetailResource>();
        }

        public long PkCostcenterid { get; set; }
        public string Costcentercode { get; set; }
        public string Costcenterdescription { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public ICollection<TblResource> TblResource { get; set; }
        public ICollection<TblScopeJobDetailResource> TblScopeJobDetailResource { get; set; }
    }
}

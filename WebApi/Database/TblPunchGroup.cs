using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblPunchGroup
    {
        public TblPunchGroup()
        {
            TblScopePunchlist = new HashSet<TblScopePunchlist>();
        }

        public long PkPunchgroupid { get; set; }
        public string Description { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public ICollection<TblScopePunchlist> TblScopePunchlist { get; set; }
    }
}

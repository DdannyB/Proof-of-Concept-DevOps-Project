using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblPriority
    {
        public TblPriority()
        {
            TblChangeRequest = new HashSet<TblChangeRequest>();
        }

        public long PkPriorityid { get; set; }
        public string Prioritycode { get; set; }
        public string Prioritydescription { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public ICollection<TblChangeRequest> TblChangeRequest { get; set; }
    }
}

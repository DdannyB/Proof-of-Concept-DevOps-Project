using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblExecution
    {
        public TblExecution()
        {
            TblChangeRequest = new HashSet<TblChangeRequest>();
        }

        public long PkExecutionid { get; set; }
        public string Executioncode { get; set; }
        public string Executiondescription { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public ICollection<TblChangeRequest> TblChangeRequest { get; set; }
    }
}

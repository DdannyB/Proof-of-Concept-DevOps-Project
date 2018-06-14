using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblExceptionContractor
    {
        public long PkExceptioncontractorid { get; set; }
        public long FkExceptionid { get; set; }
        public long FkContractorid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblContractor FkContractor { get; set; }
        public TblException FkException { get; set; }
    }
}

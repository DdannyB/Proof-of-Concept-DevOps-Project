using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblExceptionResource
    {
        public long PkExceptionresourceid { get; set; }
        public long FkExceptionid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long? FkResourceid { get; set; }

        public TblException FkException { get; set; }
        public TblResource FkResource { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblLislLislRemark
    {
        public long PkLisllislremarkid { get; set; }
        public long FkLislid { get; set; }
        public long FkLislremarkid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblLisl FkLisl { get; set; }
        public TblLislRemark FkLislremark { get; set; }
    }
}

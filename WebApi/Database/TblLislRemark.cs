using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblLislRemark
    {
        public TblLislRemark()
        {
            TblLislLislRemark = new HashSet<TblLislLislRemark>();
        }

        public long PkLislremarkid { get; set; }
        public string Lislremark { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public ICollection<TblLislLislRemark> TblLislLislRemark { get; set; }
    }
}

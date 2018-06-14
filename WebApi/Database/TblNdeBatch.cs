using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblNdeBatch
    {
        public TblNdeBatch()
        {
            TblNdeRequest = new HashSet<TblNdeRequest>();
        }

        public long PkNdebatchid { get; set; }
        public long FkProjectid { get; set; }
        public string Batchnr { get; set; }
        public string Batchname { get; set; }
        public DateTime? Freezedate { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long? FkFreezeuserid { get; set; }

        public TblUser FkFreezeuser { get; set; }
        public TblProject FkProject { get; set; }
        public ICollection<TblNdeRequest> TblNdeRequest { get; set; }
    }
}

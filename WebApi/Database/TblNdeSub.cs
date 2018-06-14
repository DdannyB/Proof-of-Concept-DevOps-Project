using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblNdeSub
    {
        public TblNdeSub()
        {
            TblNdeRequest = new HashSet<TblNdeRequest>();
        }

        public long PkNdesubid { get; set; }
        public long FkNdemainid { get; set; }
        public string Code { get; set; }
        public string Spec { get; set; }
        public string En { get; set; }
        public string Nl { get; set; }
        public string De { get; set; }
        public string Fr { get; set; }
        public string Es { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long? FkDocumentlabelid { get; set; }

        public TblDocumentLabel FkDocumentlabel { get; set; }
        public TblNdeMain FkNdemain { get; set; }
        public ICollection<TblNdeRequest> TblNdeRequest { get; set; }
    }
}

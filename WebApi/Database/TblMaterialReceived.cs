using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblMaterialReceived
    {
        public long PkMaterialreceivedid { get; set; }
        public long FkMaterialsourceid { get; set; }
        public decimal? Received { get; set; }
        public string Receiveduser { get; set; }
        public string Location { get; set; }
        public string Memo { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblMaterialSource FkMaterialsource { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblDataExchangeLoadStatus
    {
        public long PkDataexchangeloadstatus { get; set; }
        public long FkDataexchangestagingtableid { get; set; }
        public DateTime? Loaddate { get; set; }
        public string Loaduser { get; set; }
        public long? Numberofloadedrows { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblDataExchangeStagingTable FkDataexchangestagingtable { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblDataExchangeImportMessage
    {
        public long PkDataexchangeimportmessageid { get; set; }
        public long FkDataexchangeupdatestatusid { get; set; }
        public string Messagetext { get; set; }
        public DateTime Messagedate { get; set; }
        public int Messagetype { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblDataExchangeUpdateStatus FkDataexchangeupdatestatus { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblDataExchangeUpdateStatus
    {
        public TblDataExchangeUpdateStatus()
        {
            TblDataExchangeImportMessage = new HashSet<TblDataExchangeImportMessage>();
        }

        public long PkDataexchangeupdatestatusid { get; set; }
        public long FkDataexchangeobjecttypeid { get; set; }
        public DateTime? Sourceutcdatetime { get; set; }
        public DateTime Startdatetime { get; set; }
        public DateTime? Finishdatetime { get; set; }
        public string Updatetype { get; set; }
        public long? Numbersuccessful { get; set; }
        public long? Numberofwarnings { get; set; }
        public long? Numberoferrors { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblDataExchangeObjectType FkDataexchangeobjecttype { get; set; }
        public ICollection<TblDataExchangeImportMessage> TblDataExchangeImportMessage { get; set; }
    }
}

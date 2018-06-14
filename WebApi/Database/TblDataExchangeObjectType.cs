using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblDataExchangeObjectType
    {
        public TblDataExchangeObjectType()
        {
            TblDataExchangeObjectTypeUser = new HashSet<TblDataExchangeObjectTypeUser>();
            TblDataExchangeStagingTable = new HashSet<TblDataExchangeStagingTable>();
            TblDataExchangeUpdateStatus = new HashSet<TblDataExchangeUpdateStatus>();
        }

        public long PkDataexchangeobjecttypeid { get; set; }
        public string Code { get; set; }
        public string Dataexchangeobjecttypedescription { get; set; }
        public bool Isvisible { get; set; }
        public string Spname { get; set; }
        public DateTime? Spactive { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public int Type { get; set; }

        public ICollection<TblDataExchangeObjectTypeUser> TblDataExchangeObjectTypeUser { get; set; }
        public ICollection<TblDataExchangeStagingTable> TblDataExchangeStagingTable { get; set; }
        public ICollection<TblDataExchangeUpdateStatus> TblDataExchangeUpdateStatus { get; set; }
    }
}

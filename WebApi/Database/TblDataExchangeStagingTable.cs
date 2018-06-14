using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblDataExchangeStagingTable
    {
        public TblDataExchangeStagingTable()
        {
            TblDataExchangeLoadStatus = new HashSet<TblDataExchangeLoadStatus>();
            TblDataExchangeStagingTableUser = new HashSet<TblDataExchangeStagingTableUser>();
        }

        public long PkDataexchangestagingtableid { get; set; }
        public long FkDataexchangeobjecttypeid { get; set; }
        public string Stagingtablename { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public bool? Iseditable { get; set; }

        public TblDataExchangeObjectType FkDataexchangeobjecttype { get; set; }
        public ICollection<TblDataExchangeLoadStatus> TblDataExchangeLoadStatus { get; set; }
        public ICollection<TblDataExchangeStagingTableUser> TblDataExchangeStagingTableUser { get; set; }
    }
}

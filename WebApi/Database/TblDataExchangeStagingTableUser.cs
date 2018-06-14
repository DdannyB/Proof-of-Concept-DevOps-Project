﻿using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblDataExchangeStagingTableUser
    {
        public long PkDataexchangestagingtableuserid { get; set; }
        public long FkDataexchangestagingtableid { get; set; }
        public long FkUserid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblDataExchangeStagingTable FkDataexchangestagingtable { get; set; }
        public TblUser FkUser { get; set; }
    }
}
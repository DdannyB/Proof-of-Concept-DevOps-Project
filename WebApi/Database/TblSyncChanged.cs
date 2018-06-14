using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblSyncChanged
    {
        public long PkSyncchangedid { get; set; }
        public int Syncchangedtype { get; set; }
        public long Syncchangeddatabaseid { get; set; }
        public string Syncchangedhash { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public string Syncchangedtypename { get; set; }
    }
}

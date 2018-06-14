using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblWeldConnectionWelder
    {
        public long PkWeldconnectionwelderid { get; set; }
        public long FkWeldconnectionid { get; set; }
        public long FkWelderid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblWeldConnection FkWeldconnection { get; set; }
        public TblWelder FkWelder { get; set; }
    }
}

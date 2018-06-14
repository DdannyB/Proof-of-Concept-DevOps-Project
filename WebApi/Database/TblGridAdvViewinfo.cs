using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblGridAdvViewinfo
    {
        public long PkGridadvviewinfoid { get; set; }
        public string Keyfield { get; set; }
        public long? FkProjectid { get; set; }
        public long? FkUserid { get; set; }
        public string Value { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long FkGridviewinfoid { get; set; }

        public TblGridViewinfo FkGridviewinfo { get; set; }
        public TblProject FkProject { get; set; }
        public TblUser FkUser { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblPushUser
    {
        public long PkPushuserid { get; set; }
        public DateTime Timestamp { get; set; }
        public int Platform { get; set; }
        public string Channelid { get; set; }
        public string Deviceid { get; set; }
        public long FkUserid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblUser FkUser { get; set; }
    }
}

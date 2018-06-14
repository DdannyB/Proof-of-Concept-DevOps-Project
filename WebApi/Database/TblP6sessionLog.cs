﻿using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblP6sessionLog
    {
        public long PkP6sessionlogid { get; set; }
        public long FkP6sessionid { get; set; }
        public int? Oldid { get; set; }
        public string Olddb { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public string Log { get; set; }

        public TblP6session FkP6session { get; set; }
    }
}
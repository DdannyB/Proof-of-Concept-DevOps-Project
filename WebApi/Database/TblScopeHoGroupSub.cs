﻿using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblScopeHoGroupSub
    {
        public long PkScopehogroupsubid { get; set; }
        public long FkScopeid { get; set; }
        public long FkHogroupsubid { get; set; }
        public int? Oldid { get; set; }
        public string Olddb { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblHandoverGroupSub FkHogroupsub { get; set; }
        public TblScope FkScope { get; set; }
    }
}

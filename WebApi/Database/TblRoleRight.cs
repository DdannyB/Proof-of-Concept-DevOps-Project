using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblRoleRight
    {
        public long PkRolerightid { get; set; }
        public long FkRoleid { get; set; }
        public long FkRightid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblRight FkRight { get; set; }
        public TblRole FkRole { get; set; }
    }
}

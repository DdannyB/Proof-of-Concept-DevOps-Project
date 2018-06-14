using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblUserApplicationProjectRole
    {
        public long PkUserapplicationprojectroleid { get; set; }
        public long FkUserapplicationprojectid { get; set; }
        public long FkRoleid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblRole FkRole { get; set; }
        public TblUserApplicationProject FkUserapplicationproject { get; set; }
    }
}

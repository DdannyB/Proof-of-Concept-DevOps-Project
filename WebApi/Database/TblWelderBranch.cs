using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblWelderBranch
    {
        public long PkWelderbranchid { get; set; }
        public long FkWelderid { get; set; }
        public long FkBranchid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblBranch FkBranch { get; set; }
        public TblWelder FkWelder { get; set; }
    }
}

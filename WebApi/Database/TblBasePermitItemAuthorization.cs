using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblBasePermitItemAuthorization
    {
        public long PkBasepermititemauthorizationid { get; set; }
        public long FkBasepermititemid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long FkBasepermitauthorizationid { get; set; }

        public TblBasePermitAuthorization FkBasepermitauthorization { get; set; }
        public TblBasePermitItem FkBasepermititem { get; set; }
    }
}

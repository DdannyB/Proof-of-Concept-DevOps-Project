using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblTemplateBlindPointProduct
    {
        public long PkTemplateblindpointproductid { get; set; }
        public long FkTemplateblindpointid { get; set; }
        public long FkProductid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblProduct FkProduct { get; set; }
        public TblTemplateBlindPoint FkTemplateblindpoint { get; set; }
    }
}

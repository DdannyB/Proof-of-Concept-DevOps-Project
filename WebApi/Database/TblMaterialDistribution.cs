using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblMaterialDistribution
    {
        public long PkMaterialdistributionid { get; set; }
        public long FkMaterialsourceid { get; set; }
        public long? FkScopejobid { get; set; }
        public decimal? Distributed { get; set; }
        public string Handouttouser { get; set; }
        public string Handoutbyuser { get; set; }
        public DateTime Handoutdate { get; set; }
        public string Memo { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblMaterialSource FkMaterialsource { get; set; }
    }
}

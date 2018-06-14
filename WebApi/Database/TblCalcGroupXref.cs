using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblCalcGroupXref
    {
        public long PkCalcgroupxrefid { get; set; }
        public long FkCalcgroupsubid1 { get; set; }
        public long FkCalcgroupsubid2 { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblCalcGroupSub FkCalcgroupsubid1Navigation { get; set; }
        public TblCalcGroupSub FkCalcgroupsubid2Navigation { get; set; }
    }
}

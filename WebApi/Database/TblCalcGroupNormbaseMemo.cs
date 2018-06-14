using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblCalcGroupNormbaseMemo
    {
        public long PkCalcgroupnormbasememoid { get; set; }
        public long FkCalcgroupmainid { get; set; }
        public long FkCalcgroupsubid { get; set; }
        public long FkNormbasememoid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblCalcGroupMain FkCalcgroupmain { get; set; }
        public TblCalcGroupSub FkCalcgroupsub { get; set; }
        public TblNormbaseMemo FkNormbasememo { get; set; }
    }
}

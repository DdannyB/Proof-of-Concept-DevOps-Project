using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblCalcGroupCorfactor
    {
        public long PkCalcgroupcorfactorid { get; set; }
        public long FkCalcgroupmainid { get; set; }
        public long FkCalcgroupsubid { get; set; }
        public long FkCalccorfactorid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblCalcCorfactor FkCalccorfactor { get; set; }
        public TblCalcGroupMain FkCalcgroupmain { get; set; }
        public TblCalcGroupSub FkCalcgroupsub { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblMaterialGroupBi
    {
        public long PkMaterialgroupbi { get; set; }
        public long Materialgroupid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblComplexityItemSubGroup
    {
        public TblComplexityItemSubGroup()
        {
            TblComplexityItem = new HashSet<TblComplexityItem>();
        }

        public long PkComplexityitemsubgroupid { get; set; }
        public long FkComplexityitemmaingroupid { get; set; }
        public string Complexityitemsubgroupname { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblComplexityItemMainGroup FkComplexityitemmaingroup { get; set; }
        public ICollection<TblComplexityItem> TblComplexityItem { get; set; }
    }
}

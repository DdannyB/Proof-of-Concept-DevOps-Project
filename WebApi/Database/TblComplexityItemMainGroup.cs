using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblComplexityItemMainGroup
    {
        public TblComplexityItemMainGroup()
        {
            TblComplexityItemSubGroup = new HashSet<TblComplexityItemSubGroup>();
        }

        public long PkComplexityitemmaingroupid { get; set; }
        public string Complexityitemmaingroupname { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public ICollection<TblComplexityItemSubGroup> TblComplexityItemSubGroup { get; set; }
    }
}

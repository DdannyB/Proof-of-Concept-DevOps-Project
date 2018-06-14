using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblComplexityItemReviewSubGroup
    {
        public long PkComplexityitemreviewsubgroupid { get; set; }
        public long FkComplexityitemid { get; set; }
        public long FkReviewsubgroupid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblComplexityItem FkComplexityitem { get; set; }
        public TblReviewSubGroup FkReviewsubgroup { get; set; }
    }
}

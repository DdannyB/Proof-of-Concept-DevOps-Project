using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblChecklistItemGroupReviewSubGroup
    {
        public long PkChecklistitemgroupreviewsubgroupid { get; set; }
        public long FkChecklistitemgroupid { get; set; }
        public long FkReviewsubgroupid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblChecklistItemGroup FkChecklistitemgroup { get; set; }
        public TblReviewSubGroup FkReviewsubgroup { get; set; }
    }
}

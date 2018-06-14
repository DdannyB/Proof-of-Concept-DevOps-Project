using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblReview
    {
        public TblReview()
        {
            TblReviewComplexityItem = new HashSet<TblReviewComplexityItem>();
        }

        public long PkReviewid { get; set; }
        public long FkChangerequestid { get; set; }
        public long FkUserid { get; set; }
        public long FkReviewsubgroupid { get; set; }
        public int? Reviewresult { get; set; }
        public string Reviewcomment { get; set; }
        public DateTime? Reviewstarted { get; set; }
        public DateTime? Reviewcompleted { get; set; }
        public DateTime? Responsedate { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long FkWorkflowstateid { get; set; }
        public string Responseuser { get; set; }

        public TblChangeRequest FkChangerequest { get; set; }
        public TblReviewSubGroup FkReviewsubgroup { get; set; }
        public TblUser FkUser { get; set; }
        public TblWorkflowState FkWorkflowstate { get; set; }
        public ICollection<TblReviewComplexityItem> TblReviewComplexityItem { get; set; }
    }
}

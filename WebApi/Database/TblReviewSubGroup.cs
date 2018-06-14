using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblReviewSubGroup
    {
        public TblReviewSubGroup()
        {
            TblChecklistItemGroupReviewSubGroup = new HashSet<TblChecklistItemGroupReviewSubGroup>();
            TblComplexityItemReviewSubGroup = new HashSet<TblComplexityItemReviewSubGroup>();
            TblProcessAreaUserReviewSubGroup = new HashSet<TblProcessAreaUserReviewSubGroup>();
            TblReview = new HashSet<TblReview>();
            TblUserReviewSubGroup = new HashSet<TblUserReviewSubGroup>();
        }

        public long PkReviewsubgroupid { get; set; }
        public long FkReviewmaingroupid { get; set; }
        public long? FkDefaultchecklistid { get; set; }
        public string Reviewsubgroupname { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblChecklist FkDefaultchecklist { get; set; }
        public TblReviewMainGroup FkReviewmaingroup { get; set; }
        public ICollection<TblChecklistItemGroupReviewSubGroup> TblChecklistItemGroupReviewSubGroup { get; set; }
        public ICollection<TblComplexityItemReviewSubGroup> TblComplexityItemReviewSubGroup { get; set; }
        public ICollection<TblProcessAreaUserReviewSubGroup> TblProcessAreaUserReviewSubGroup { get; set; }
        public ICollection<TblReview> TblReview { get; set; }
        public ICollection<TblUserReviewSubGroup> TblUserReviewSubGroup { get; set; }
    }
}

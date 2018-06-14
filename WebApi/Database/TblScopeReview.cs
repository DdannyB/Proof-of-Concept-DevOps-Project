using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblScopeReview
    {
        public long PkScopereviewid { get; set; }
        public long FkScopeid { get; set; }
        public long FkReviewgroupid { get; set; }
        public long? FkUserid { get; set; }
        public int? Oldid { get; set; }
        public string Olddb { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public string Reviewmemo { get; set; }
        public DateTime? Reviewdate { get; set; }
        public DateTime? Handlingdate { get; set; }
        public string Handlingstatus { get; set; }
        public string Handlingmemo { get; set; }

        public TblReviewGroup FkReviewgroup { get; set; }
        public TblScope FkScope { get; set; }
        public TblUser FkUser { get; set; }
    }
}

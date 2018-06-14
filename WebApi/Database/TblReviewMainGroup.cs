using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblReviewMainGroup
    {
        public TblReviewMainGroup()
        {
            TblReviewSubGroup = new HashSet<TblReviewSubGroup>();
        }

        public long PkReviewmaingroupid { get; set; }
        public string Reviewmaingroupname { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public ICollection<TblReviewSubGroup> TblReviewSubGroup { get; set; }
    }
}

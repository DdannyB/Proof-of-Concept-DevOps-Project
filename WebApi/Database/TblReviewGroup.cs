using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblReviewGroup
    {
        public TblReviewGroup()
        {
            TblScopeReview = new HashSet<TblScopeReview>();
            TblUserSecurity = new HashSet<TblUserSecurity>();
        }

        public long PkReviewgroupid { get; set; }
        public string Groupname { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public ICollection<TblScopeReview> TblScopeReview { get; set; }
        public ICollection<TblUserSecurity> TblUserSecurity { get; set; }
    }
}

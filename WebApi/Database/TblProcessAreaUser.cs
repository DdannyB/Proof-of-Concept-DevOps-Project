﻿using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblProcessAreaUser
    {
        public TblProcessAreaUser()
        {
            TblProcessAreaUserReviewSubGroup = new HashSet<TblProcessAreaUserReviewSubGroup>();
        }

        public long PkProcessareauserid { get; set; }
        public long FkUserid { get; set; }
        public long FkProcessareaid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblProcessarea FkProcessarea { get; set; }
        public TblUser FkUser { get; set; }
        public ICollection<TblProcessAreaUserReviewSubGroup> TblProcessAreaUserReviewSubGroup { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblLibraryJobRevisionInfo
    {
        public TblLibraryJobRevisionInfo()
        {
            TblLibraryJob = new HashSet<TblLibraryJob>();
        }

        public long PkLibraryjobrevisioninfoid { get; set; }
        public long FkLibraryactivejobid { get; set; }
        public long FkRevisioninfoid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblLibraryActiveJob FkLibraryactivejob { get; set; }
        public TblRevisionInfo FkRevisioninfo { get; set; }
        public ICollection<TblLibraryJob> TblLibraryJob { get; set; }
    }
}

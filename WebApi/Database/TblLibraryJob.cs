using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblLibraryJob
    {
        public TblLibraryJob()
        {
            TblLibraryScopeTemplateJob = new HashSet<TblLibraryScopeTemplateJob>();
            TblScopeJob = new HashSet<TblScopeJob>();
        }

        public long PkLibraryjobid { get; set; }
        public long? FkLibraryjobrevisioninfoid { get; set; }
        public long FkJobid { get; set; }
        public string Libraryjobcode { get; set; }
        public string Publishedcomputer { get; set; }
        public string Publisheduser { get; set; }
        public DateTime? Publisheddate { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblJob FkJob { get; set; }
        public TblLibraryJobRevisionInfo FkLibraryjobrevisioninfo { get; set; }
        public TblLibraryActiveJob TblLibraryActiveJob { get; set; }
        public ICollection<TblLibraryScopeTemplateJob> TblLibraryScopeTemplateJob { get; set; }
        public ICollection<TblScopeJob> TblScopeJob { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblJob
    {
        public TblJob()
        {
            TblJobDetail = new HashSet<TblJobDetail>();
            TblLibraryJob = new HashSet<TblLibraryJob>();
            TblLibraryScopeTemplateJob = new HashSet<TblLibraryScopeTemplateJob>();
        }

        public long PkJobid { get; set; }
        public long FkJobdataid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblJobData FkJobdata { get; set; }
        public ICollection<TblJobDetail> TblJobDetail { get; set; }
        public ICollection<TblLibraryJob> TblLibraryJob { get; set; }
        public ICollection<TblLibraryScopeTemplateJob> TblLibraryScopeTemplateJob { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblLibraryJobXref
    {
        public long PkLibraryjobxrefid { get; set; }
        public long FkLibraryactivejobid1 { get; set; }
        public long FkLibraryactivejobid2 { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblLibraryActiveJob FkLibraryactivejobid1Navigation { get; set; }
        public TblLibraryActiveJob FkLibraryactivejobid2Navigation { get; set; }
    }
}

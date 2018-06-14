using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblLibraryActiveJob
    {
        public TblLibraryActiveJob()
        {
            TblBasePermitMaintenanceStrategyDetails = new HashSet<TblBasePermitMaintenanceStrategyDetails>();
            TblLibraryJobRevisionInfo = new HashSet<TblLibraryJobRevisionInfo>();
            TblWallpaperDynamicColDetail = new HashSet<TblWallpaperDynamicColDetail>();
        }

        public long PkLibraryactivejobid { get; set; }
        public long FkLibraryjobid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblLibraryJob FkLibraryjob { get; set; }
        public TblLibraryJobXref TblLibraryJobXrefFkLibraryactivejobid1Navigation { get; set; }
        public TblLibraryJobXref TblLibraryJobXrefFkLibraryactivejobid2Navigation { get; set; }
        public ICollection<TblBasePermitMaintenanceStrategyDetails> TblBasePermitMaintenanceStrategyDetails { get; set; }
        public ICollection<TblLibraryJobRevisionInfo> TblLibraryJobRevisionInfo { get; set; }
        public ICollection<TblWallpaperDynamicColDetail> TblWallpaperDynamicColDetail { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblWallpaperDynamicColDetail
    {
        public long PkWallpaperdynamiccoldetaiid { get; set; }
        public long? FkWallpaperdynamiccolid { get; set; }
        public long? FkMainphaseid { get; set; }
        public long? FkSubphaseid { get; set; }
        public int? Oldid { get; set; }
        public string Olddb { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long? FkResourceid { get; set; }
        public long? FkLibraryactivejobid { get; set; }

        public TblLibraryActiveJob FkLibraryactivejob { get; set; }
        public TblMainPhase FkMainphase { get; set; }
        public TblResource FkResource { get; set; }
        public TblSubPhase FkSubphase { get; set; }
        public TblWallpaperDynamicCol FkWallpaperdynamiccol { get; set; }
    }
}

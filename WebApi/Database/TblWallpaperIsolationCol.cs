using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblWallpaperIsolationCol
    {
        public long PkWallpaperisolationcol { get; set; }
        public long FkWallpaperid { get; set; }
        public long FkMainphaseid { get; set; }
        public long FkSubphaseid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblMainPhase FkMainphase { get; set; }
        public TblSubPhase FkSubphase { get; set; }
        public TblWallpaper FkWallpaper { get; set; }
    }
}

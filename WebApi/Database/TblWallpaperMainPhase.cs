using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblWallpaperMainPhase
    {
        public int PkWallpapermainphaseid { get; set; }
        public long? FkWallpaperid { get; set; }
        public long? FkMainphaseid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblMainPhase FkMainphase { get; set; }
        public TblWallpaper FkWallpaper { get; set; }
    }
}

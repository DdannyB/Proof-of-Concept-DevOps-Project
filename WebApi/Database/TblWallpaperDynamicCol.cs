using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblWallpaperDynamicCol
    {
        public TblWallpaperDynamicCol()
        {
            TblWallpaperDynamicColDetail = new HashSet<TblWallpaperDynamicColDetail>();
        }

        public long PkWallpaperdynamiccolid { get; set; }
        public long FkWallpaperid { get; set; }
        public int? Oldid { get; set; }
        public string Olddb { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public string Columnname { get; set; }
        public int Position { get; set; }
        public int? Bordercolor { get; set; }

        public TblWallpaper FkWallpaper { get; set; }
        public ICollection<TblWallpaperDynamicColDetail> TblWallpaperDynamicColDetail { get; set; }
    }
}

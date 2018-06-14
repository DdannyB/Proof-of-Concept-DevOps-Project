using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblWallpaperBand
    {
        public long PkWallpaperbandid { get; set; }
        public long FkWallpaperid { get; set; }
        public int? Oldid { get; set; }
        public string Olddb { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public string Bandname { get; set; }
        public bool Isactive { get; set; }
        public bool Isvertical { get; set; }
        public int Displayheightvertical { get; set; }
        public int Rptheight { get; set; }
        public int Displayformat { get; set; }

        public TblWallpaper FkWallpaper { get; set; }
    }
}

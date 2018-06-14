using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblWallpaperStaticCol
    {
        public long PkWallpaperstaticcolid { get; set; }
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
        public int Displaywidth { get; set; }
        public int Rptwidth { get; set; }
        public bool Isfixed { get; set; }
        public long? FkPlantcustomid { get; set; }
        public int Statictype { get; set; }
        public int Displayformat { get; set; }
        public int? Visiblegroupindex { get; set; }

        public TblPlantCustom FkPlantcustom { get; set; }
        public TblWallpaper FkWallpaper { get; set; }
    }
}

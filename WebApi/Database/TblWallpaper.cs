using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblWallpaper
    {
        public TblWallpaper()
        {
            TblPlaylistItem = new HashSet<TblPlaylistItem>();
            TblWallpaperBand = new HashSet<TblWallpaperBand>();
            TblWallpaperDynamicCol = new HashSet<TblWallpaperDynamicCol>();
            TblWallpaperFilter = new HashSet<TblWallpaperFilter>();
            TblWallpaperIsolationCol = new HashSet<TblWallpaperIsolationCol>();
            TblWallpaperMainPhase = new HashSet<TblWallpaperMainPhase>();
            TblWallpaperStaticCol = new HashSet<TblWallpaperStaticCol>();
        }

        public long PkWallpaperid { get; set; }
        public long? FkProjectid { get; set; }
        public int? Oldid { get; set; }
        public string Olddb { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public string Wallpapername { get; set; }
        public int? Groupcolor { get; set; }
        public bool Rptpagebreakgrouping { get; set; }
        public int Rptheightdetailrow { get; set; }
        public decimal Rptfontsize { get; set; }
        public bool Rptshowprogress { get; set; }
        public bool Rptshowqc { get; set; }
        public bool? Showqccolumn { get; set; }
        public bool? Showmainphasecolumns { get; set; }
        public bool? Showoverallprogresscolumn { get; set; }
        public bool Exclude100percent { get; set; }
        public DateTime Startdate { get; set; }
        public DateTime Enddate { get; set; }
        public int Wallpapertype { get; set; }
        public bool Rptshowitemtostarticon { get; set; }
        public bool Showjobtostartcolumn { get; set; }
        public int Jobtostartcolumndisplaywidth { get; set; }
        public int Jobtostartcolumnrptwidth { get; set; }
        public int Datecolumndisplaywidth { get; set; }
        public int Jobviewtype { get; set; }
        public bool Showitemtostarticon { get; set; }
        public bool Showprogressonmainphase { get; set; }
        public bool Showisolationgroupingcolors { get; set; }
        public bool Showactivephases { get; set; }
        public int Plusweeks { get; set; }
        public bool Thisweek { get; set; }

        public TblProject FkProject { get; set; }
        public ICollection<TblPlaylistItem> TblPlaylistItem { get; set; }
        public ICollection<TblWallpaperBand> TblWallpaperBand { get; set; }
        public ICollection<TblWallpaperDynamicCol> TblWallpaperDynamicCol { get; set; }
        public ICollection<TblWallpaperFilter> TblWallpaperFilter { get; set; }
        public ICollection<TblWallpaperIsolationCol> TblWallpaperIsolationCol { get; set; }
        public ICollection<TblWallpaperMainPhase> TblWallpaperMainPhase { get; set; }
        public ICollection<TblWallpaperStaticCol> TblWallpaperStaticCol { get; set; }
    }
}

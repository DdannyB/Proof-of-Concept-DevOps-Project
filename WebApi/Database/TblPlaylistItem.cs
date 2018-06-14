using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblPlaylistItem
    {
        public long PkPlaylistitemid { get; set; }
        public long FkPlaylistid { get; set; }
        public int Playlistitemsortorder { get; set; }
        public int? Playlistitemseconds { get; set; }
        public int? Playlistitemscrollseconds { get; set; }
        public long? FkWallpaperid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblPlaylist FkPlaylist { get; set; }
        public TblWallpaper FkWallpaper { get; set; }
    }
}

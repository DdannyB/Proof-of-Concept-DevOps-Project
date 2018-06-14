using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblPlaylist
    {
        public TblPlaylist()
        {
            TblPlaylistItem = new HashSet<TblPlaylistItem>();
        }

        public long PkPlaylistid { get; set; }
        public long? FkUserid { get; set; }
        public string Playlistname { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblUser FkUser { get; set; }
        public ICollection<TblPlaylistItem> TblPlaylistItem { get; set; }
    }
}

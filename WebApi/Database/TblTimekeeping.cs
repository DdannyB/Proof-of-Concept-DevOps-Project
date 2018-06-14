using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblTimekeeping
    {
        public TblTimekeeping()
        {
            TblTimekeepingEntry = new HashSet<TblTimekeepingEntry>();
        }

        public long PkTimekeepingid { get; set; }
        public long FkUserid { get; set; }
        public DateTime Datetimein { get; set; }
        public DateTime? Datetimeout { get; set; }
        public byte[] Imagein { get; set; }
        public byte[] Imageout { get; set; }
        public string Gateinname { get; set; }
        public string Gateoutname { get; set; }
        public DateTime? Mergedate { get; set; }
        public string Guid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblUser FkUser { get; set; }
        public ICollection<TblTimekeepingEntry> TblTimekeepingEntry { get; set; }
    }
}

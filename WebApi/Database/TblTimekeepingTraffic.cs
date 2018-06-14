using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblTimekeepingTraffic
    {
        public TblTimekeepingTraffic()
        {
            TblTimekeepingTrafficData = new HashSet<TblTimekeepingTrafficData>();
        }

        public int PkTimekeepingtrafficid { get; set; }
        public string Description { get; set; }
        public decimal? Minvalue { get; set; }
        public decimal? Maxvalue { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public ICollection<TblTimekeepingTrafficData> TblTimekeepingTrafficData { get; set; }
    }
}

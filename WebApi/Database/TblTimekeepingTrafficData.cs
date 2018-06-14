using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblTimekeepingTrafficData
    {
        public int PkTimekeepingtrafficdata { get; set; }
        public int FkTimekeepingtrafficid { get; set; }
        public int Color { get; set; }
        public decimal Minvalue { get; set; }
        public decimal Maxvalue { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblTimekeepingTraffic FkTimekeepingtraffic { get; set; }
    }
}

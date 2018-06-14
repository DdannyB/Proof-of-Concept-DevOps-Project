using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblPlantDataPid
    {
        public long PkPlantdatapidid { get; set; }
        public long FkPlantdataid { get; set; }
        public long FkPidid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long? FkStartpidrevisionid { get; set; }
        public long? FkEndpidrevisionid { get; set; }

        public TblPidRevision FkEndpidrevision { get; set; }
        public TblPid FkPid { get; set; }
        public TblPlantData FkPlantdata { get; set; }
        public TblPidRevision FkStartpidrevision { get; set; }
    }
}

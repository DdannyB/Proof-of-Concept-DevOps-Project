using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblChangeRequestAdditionalPlantData
    {
        public long PkChangerequestadditionalplantdataid { get; set; }
        public long FkChangerequestid { get; set; }
        public long FkPlantdataid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblChangeRequest FkChangerequest { get; set; }
        public TblPlantData FkPlantdata { get; set; }
    }
}

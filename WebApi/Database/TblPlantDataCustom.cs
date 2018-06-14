using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblPlantDataCustom
    {
        public long PkPlantdatacustomid { get; set; }
        public long FkPlantdataid { get; set; }
        public long FkPlantcustomid { get; set; }
        public string Customvalue { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblPlantCustom FkPlantcustom { get; set; }
        public TblPlantData FkPlantdata { get; set; }
    }
}

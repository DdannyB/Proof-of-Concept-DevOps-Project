using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblMaterialCustom
    {
        public long PkMaterialcustomid { get; set; }
        public string Description { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public string Unloadingpoint { get; set; }
        public string Trackingnumber { get; set; }
        public string Storagelocation { get; set; }
        public string Goodsrecipient { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblQualityCheckType
    {
        public long PkQualitycheckid { get; set; }
        public string Qualitycheckdescription { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
    }
}

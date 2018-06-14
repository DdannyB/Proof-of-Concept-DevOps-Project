using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblJfactorExposure
    {
        public long PkJfactorexposureid { get; set; }
        public string Jfactorexposuredescription { get; set; }
        public decimal Score { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
    }
}

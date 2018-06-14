using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblLicense
    {
        public long PkLicenseid { get; set; }
        public string Licensekey { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
    }
}

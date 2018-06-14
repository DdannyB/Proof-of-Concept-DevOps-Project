using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblCertificateCustomValue
    {
        public long PkCertificatecustomvalueid { get; set; }
        public long FkCertificateid { get; set; }
        public long FkCertificatecustomnameid { get; set; }
        public string Customvalue { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblCertificate FkCertificate { get; set; }
        public TblCertificateCustomName FkCertificatecustomname { get; set; }
    }
}

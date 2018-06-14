using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblCertificateCustomName
    {
        public TblCertificateCustomName()
        {
            TblCertificateCustomValue = new HashSet<TblCertificateCustomValue>();
        }

        public long PkCertificatecustomnameid { get; set; }
        public string Customname { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public ICollection<TblCertificateCustomValue> TblCertificateCustomValue { get; set; }
    }
}

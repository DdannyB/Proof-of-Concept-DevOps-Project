using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblDigitalSignature
    {
        public long PkDigitalsignatureid { get; set; }
        public long? FkPermititempartid { get; set; }
        public long FkUserid { get; set; }
        public int Digitalsignaturetype { get; set; }
        public int Stamptype { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public DateTime Signaturedate { get; set; }

        public TblPermitItemPart FkPermititempart { get; set; }
        public TblUser FkUser { get; set; }
    }
}

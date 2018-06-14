using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblPermitItemPart
    {
        public TblPermitItemPart()
        {
            TblDigitalSignature = new HashSet<TblDigitalSignature>();
        }

        public long PkPermititempartid { get; set; }
        public long FkPermitid { get; set; }
        public long FkBasepermititempartid { get; set; }
        public string Textvalue { get; set; }
        public bool State { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long? DkSelectedid { get; set; }

        public TblBasePermitItemPart FkBasepermititempart { get; set; }
        public TblPermit FkPermit { get; set; }
        public ICollection<TblDigitalSignature> TblDigitalSignature { get; set; }
    }
}

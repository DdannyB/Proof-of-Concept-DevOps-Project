using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblScopeQaqcQuicklist
    {
        public long PkScopeqaqcquicklistid { get; set; }
        public long FkScopeid { get; set; }
        public long FkQaqcquicklistid { get; set; }
        public long? FkContractorid { get; set; }
        public int? Oldid { get; set; }
        public string Olddb { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public string Accepteduser { get; set; }
        public DateTime? Accepteddate { get; set; }
        public string Issueduser { get; set; }
        public DateTime? Issueddate { get; set; }
        public string Receiveduser { get; set; }
        public DateTime? Receiveddate { get; set; }
        public string Riptest { get; set; }
        public string Roptest { get; set; }
        public string Thirdtest { get; set; }

        public TblContractor FkContractor { get; set; }
        public TblQaqcQuicklist FkQaqcquicklist { get; set; }
        public TblScope FkScope { get; set; }
    }
}

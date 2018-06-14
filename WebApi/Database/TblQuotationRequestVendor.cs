using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblQuotationRequestVendor
    {
        public long PkQuotationrequestvendorid { get; set; }
        public long FkQuotationrequestid { get; set; }
        public long FkContractorid { get; set; }
        public int? Oldid { get; set; }
        public string Olddb { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public string Emailfrom { get; set; }
        public string Emailto { get; set; }
        public DateTime? Bidoutdate { get; set; }
        public DateTime? Bidindate { get; set; }

        public TblContractor FkContractor { get; set; }
        public TblQuotationRequest FkQuotationrequest { get; set; }
    }
}

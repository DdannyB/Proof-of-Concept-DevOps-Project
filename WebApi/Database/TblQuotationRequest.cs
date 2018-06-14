using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblQuotationRequest
    {
        public TblQuotationRequest()
        {
            TblQuotationRequestVendor = new HashSet<TblQuotationRequestVendor>();
        }

        public long PkQuotationrequestid { get; set; }
        public long FkUserid { get; set; }
        public long FkProjectid { get; set; }
        public int? Oldid { get; set; }
        public string Olddb { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public string Requestnr { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public string Memo { get; set; }

        public TblProject FkProject { get; set; }
        public TblUser FkUser { get; set; }
        public ICollection<TblQuotationRequestVendor> TblQuotationRequestVendor { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblScopePunchlist
    {
        public TblScopePunchlist()
        {
            TblAttachment = new HashSet<TblAttachment>();
            TblScopePunchlistDocumentLabel = new HashSet<TblScopePunchlistDocumentLabel>();
        }

        public long PkScopepunchlistid { get; set; }
        public long FkScopeid { get; set; }
        public long? FkPunchgroupid { get; set; }
        public long? FkContractorid { get; set; }
        public int? Oldid { get; set; }
        public string Olddb { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public string Punchnr { get; set; }
        public string Punchdescr { get; set; }
        public string Accepteduser { get; set; }
        public DateTime? Accepteddate { get; set; }
        public DateTime? Duedate { get; set; }
        public string Originuser { get; set; }
        public DateTime? Origindate { get; set; }
        public long FkPunchcategoryid { get; set; }

        public TblContractor FkContractor { get; set; }
        public TblPunchCategory FkPunchcategory { get; set; }
        public TblPunchGroup FkPunchgroup { get; set; }
        public TblScope FkScope { get; set; }
        public ICollection<TblAttachment> TblAttachment { get; set; }
        public ICollection<TblScopePunchlistDocumentLabel> TblScopePunchlistDocumentLabel { get; set; }
    }
}

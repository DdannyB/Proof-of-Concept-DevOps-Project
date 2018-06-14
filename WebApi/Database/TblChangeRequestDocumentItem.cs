using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblChangeRequestDocumentItem
    {
        public long PkChangerequestdocumentitemid { get; set; }
        public long FkChangerequestid { get; set; }
        public long FkDocumentitemid { get; set; }
        public bool Changerequestdocumentitemdone { get; set; }
        public bool Changerequestdocumentitemcheck { get; set; }
        public string Changerequestdocumentitemdescription { get; set; }
        public string Changerequestdocumentitemgeneralremark { get; set; }
        public DateTime? Changerequestdocumentitemmodifieddate { get; set; }
        public DateTime? Changerequestverifiedmodifieddate { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblChangeRequest FkChangerequest { get; set; }
        public TblDocumentItem FkDocumentitem { get; set; }
    }
}

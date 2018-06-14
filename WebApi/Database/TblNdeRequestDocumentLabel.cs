using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblNdeRequestDocumentLabel
    {
        public long PkNderequestdocumentlabelid { get; set; }
        public long FkNderequestid { get; set; }
        public long FkDocumentlabelid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblDocumentLabel FkDocumentlabel { get; set; }
        public TblNdeRequest FkNderequest { get; set; }
    }
}

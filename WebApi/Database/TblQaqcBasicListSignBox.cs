using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblQaqcBasicListSignBox
    {
        public long PkQaqcbasiclistsignboxid { get; set; }
        public long FkQaqcquicklistid { get; set; }
        public long FkBasiclistsignboxid { get; set; }
        public bool? Isactive { get; set; }
        public string Code { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblBasicListSignbox FkBasiclistsignbox { get; set; }
        public TblQaqcQuicklist FkQaqcquicklist { get; set; }
    }
}

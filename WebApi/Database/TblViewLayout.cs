using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblViewLayout
    {
        public long PkViewlayoutid { get; set; }
        public string Viewlayoutname { get; set; }
        public string Formname { get; set; }
        public string Viewname { get; set; }
        public bool Isadminview { get; set; }
        public bool Isdefaultview { get; set; }
        public long? FkUserid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public string Layout { get; set; }
        public bool? Isconverted { get; set; }

        public TblUser FkUser { get; set; }
    }
}

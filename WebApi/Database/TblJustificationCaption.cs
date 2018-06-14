using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblJustificationCaption
    {
        public long PkJustificationcaptionid { get; set; }
        public long Checkboxnr { get; set; }
        public string Justificationcaptiondescription { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
    }
}

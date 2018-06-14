using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblChecklistShortcode
    {
        public long PkChecklistshortcodeid { get; set; }
        public long FkChecklistid { get; set; }
        public long FkShortcodeid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblChecklist FkChecklist { get; set; }
        public TblShortcode FkShortcode { get; set; }
    }
}

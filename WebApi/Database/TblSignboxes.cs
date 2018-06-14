using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblSignboxes
    {
        public long PkSignboxesid { get; set; }
        public int Applicationenum { get; set; }
        public string Reportname { get; set; }
        public string Signboxname { get; set; }
        public int Displayorder { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public int? Blindliststatusenum { get; set; }
    }
}

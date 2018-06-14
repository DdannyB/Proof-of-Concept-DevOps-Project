using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblThicknessAlternative
    {
        public long PkThicknessalternativeid { get; set; }
        public long FkThicknessid { get; set; }
        public string Thicknessalternativedescription { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblThickness FkThickness { get; set; }
    }
}

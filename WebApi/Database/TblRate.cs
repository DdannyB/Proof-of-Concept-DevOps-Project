using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblRate
    {
        public long PkRateid { get; set; }
        public decimal Rate { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long FkSubdisciplineid { get; set; }

        public TblSubDiscipline FkSubdiscipline { get; set; }
    }
}

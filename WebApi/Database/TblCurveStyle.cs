using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblCurveStyle
    {
        public long PkCurveid { get; set; }
        public long? FkUserid { get; set; }
        public int Curve { get; set; }
        public int Curvecolor { get; set; }
        public int Curvestyle { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblUser FkUser { get; set; }
    }
}

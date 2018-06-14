using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblBlindListReport
    {
        public TblBlindListReport()
        {
            TblBlindListReportColumn = new HashSet<TblBlindListReportColumn>();
        }

        public long PkBlindlistreportid { get; set; }
        public string Blindlistreportdescription { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public bool Showgroupingcolor { get; set; }
        public bool Showsignature { get; set; }
        public string Signaturetext { get; set; }
        public float Detailfontsize { get; set; }
        public float Detailrowheight { get; set; }
        public string Infotextleadingscope { get; set; }
        public string Infotextnonleadingscope { get; set; }
        public int Infocolorleadingscope { get; set; }
        public int Infocolornonleadingscope { get; set; }
        public bool Automaticrowheight { get; set; }
        public int Paperkind { get; set; }
        public bool Landscape { get; set; }

        public ICollection<TblBlindListReportColumn> TblBlindListReportColumn { get; set; }
    }
}

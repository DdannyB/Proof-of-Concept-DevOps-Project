using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblBlindListReportColumn
    {
        public TblBlindListReportColumn()
        {
            TblBlindListReportColumnField = new HashSet<TblBlindListReportColumnField>();
        }

        public long PkBlindlistreportcolumnid { get; set; }
        public long FkBlindlistreportid { get; set; }
        public int Ordernr { get; set; }
        public decimal Width { get; set; }
        public string Headerdescription { get; set; }
        public long? FkMainphaseid { get; set; }
        public long? FkSubphaseid { get; set; }
        public long? FkSubdisciplineid { get; set; }
        public bool Highlightleftborder { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblBlindListReport FkBlindlistreport { get; set; }
        public TblMainPhase FkMainphase { get; set; }
        public TblSubDiscipline FkSubdiscipline { get; set; }
        public TblSubPhase FkSubphase { get; set; }
        public ICollection<TblBlindListReportColumnField> TblBlindListReportColumnField { get; set; }
    }
}

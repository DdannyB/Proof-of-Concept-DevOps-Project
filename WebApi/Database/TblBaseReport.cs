using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblBaseReport
    {
        public TblBaseReport()
        {
            TblBaseReportGroup = new HashSet<TblBaseReportGroup>();
            TblBlindPointActivityLabel = new HashSet<TblBlindPointActivityLabel>();
            TblBlindTypeNormPosActivityLabel = new HashSet<TblBlindTypeNormPosActivityLabel>();
            TblReport = new HashSet<TblReport>();
            TblReportPrinter = new HashSet<TblReportPrinter>();
        }

        public long PkBasereportid { get; set; }
        public string Basereportname { get; set; }
        public int Reporttypename { get; set; }
        public DateTime? Deleteddate { get; set; }
        public DateTime? Freezedate { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public int PaperKind { get; set; }
        public int PageWidth { get; set; }
        public int PageLength { get; set; }
        public int DetailBandLength { get; set; }
        public bool Header { get; set; }
        public bool Footer { get; set; }
        public int? Bottommargin { get; set; }
        public int? Topmargin { get; set; }

        public ICollection<TblBaseReportGroup> TblBaseReportGroup { get; set; }
        public ICollection<TblBlindPointActivityLabel> TblBlindPointActivityLabel { get; set; }
        public ICollection<TblBlindTypeNormPosActivityLabel> TblBlindTypeNormPosActivityLabel { get; set; }
        public ICollection<TblReport> TblReport { get; set; }
        public ICollection<TblReportPrinter> TblReportPrinter { get; set; }
    }
}

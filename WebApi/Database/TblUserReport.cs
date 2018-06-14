using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblUserReport
    {
        public TblUserReport()
        {
            TblPrintTemplateDetail = new HashSet<TblPrintTemplateDetail>();
            TblQaqcQuicklist = new HashSet<TblQaqcQuicklist>();
            TblUserReportFiltersToHide = new HashSet<TblUserReportFiltersToHide>();
        }

        public long PkUserreportid { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool Published { get; set; }
        public string Layout { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public bool Groupbyscope { get; set; }
        public long Reportmodule { get; set; }
        public long Datasource { get; set; }

        public ICollection<TblPrintTemplateDetail> TblPrintTemplateDetail { get; set; }
        public ICollection<TblQaqcQuicklist> TblQaqcQuicklist { get; set; }
        public ICollection<TblUserReportFiltersToHide> TblUserReportFiltersToHide { get; set; }
    }
}

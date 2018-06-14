using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblJobData
    {
        public TblJobData()
        {
            TblJob = new HashSet<TblJob>();
            TblScopeJob = new HashSet<TblScopeJob>();
        }

        public long PkJobdataid { get; set; }
        public long FkSubdisciplineid { get; set; }
        public long? FkCalendarid { get; set; }
        public long FkMainphaseid { get; set; }
        public long FkSubphaseid { get; set; }
        public string JobdescriptionL1 { get; set; }
        public string JobdescriptionL2 { get; set; }
        public string JobdescriptionL3 { get; set; }
        public string JobdescriptionL4 { get; set; }
        public string JobdescriptionL5 { get; set; }
        public string JobmemoL1 { get; set; }
        public string JobmemoL2 { get; set; }
        public string JobmemoL3 { get; set; }
        public string JobmemoL4 { get; set; }
        public string JobmemoL5 { get; set; }
        public decimal? Jobhours { get; set; }
        public decimal Jobduration { get; set; }
        public string Joboperation { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public bool Jobnotapplicableforpermit { get; set; }
        public string Jobdatacalupdate { get; set; }

        public TblCalendar FkCalendar { get; set; }
        public TblMainPhase FkMainphase { get; set; }
        public TblSubDiscipline FkSubdiscipline { get; set; }
        public TblSubPhase FkSubphase { get; set; }
        public ICollection<TblJob> TblJob { get; set; }
        public ICollection<TblScopeJob> TblScopeJob { get; set; }
    }
}

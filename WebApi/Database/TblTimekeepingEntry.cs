using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblTimekeepingEntry
    {
        public TblTimekeepingEntry()
        {
            TblTimekeepingEntryCircum = new HashSet<TblTimekeepingEntryCircum>();
            TblTimekeepingEntryInefficiency = new HashSet<TblTimekeepingEntryInefficiency>();
            TblTimekeepingEntryLog = new HashSet<TblTimekeepingEntryLog>();
        }

        public long PkTimekeepingentryid { get; set; }
        public long FkUserid { get; set; }
        public long FkTimekeepingentrytypeid { get; set; }
        public long? FkWorkflowstateid { get; set; }
        public long? FkProjectid { get; set; }
        public long? FkTimekeepingid { get; set; }
        public long? DkScopeid { get; set; }
        public long? DkScopejobid { get; set; }
        public long? DkScopejobdetailresourceid { get; set; }
        public DateTime Entrydate { get; set; }
        public DateTime? Starttime { get; set; }
        public DateTime? Stoptime { get; set; }
        public decimal Hours { get; set; }
        public bool Istimespentonly { get; set; }
        public bool Ischangedbytimeit { get; set; }
        public string Memo { get; set; }
        public decimal? Nethours { get; set; }
        public decimal? Grosshours { get; set; }
        public decimal? Overtimehours { get; set; }
        public int? Markingtype { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblProject FkProject { get; set; }
        public TblTimekeeping FkTimekeeping { get; set; }
        public TblTimekeepingEntryType FkTimekeepingentrytype { get; set; }
        public TblUser FkUser { get; set; }
        public TblWorkflowState FkWorkflowstate { get; set; }
        public ICollection<TblTimekeepingEntryCircum> TblTimekeepingEntryCircum { get; set; }
        public ICollection<TblTimekeepingEntryInefficiency> TblTimekeepingEntryInefficiency { get; set; }
        public ICollection<TblTimekeepingEntryLog> TblTimekeepingEntryLog { get; set; }
    }
}

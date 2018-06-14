using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblTimekeepingPeriod
    {
        public TblTimekeepingPeriod()
        {
            TblUserTimekeepingPeriod = new HashSet<TblUserTimekeepingPeriod>();
        }

        public long PkTimekeepingperiodid { get; set; }
        public string Timekeepingperiodcode { get; set; }
        public string Timekeepingperiodname { get; set; }
        public int Workdays { get; set; }
        public DateTime? Startdate { get; set; }
        public int Cycleenumvalue { get; set; }
        public int Splitday { get; set; }
        public int Length { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public ICollection<TblUserTimekeepingPeriod> TblUserTimekeepingPeriod { get; set; }
    }
}

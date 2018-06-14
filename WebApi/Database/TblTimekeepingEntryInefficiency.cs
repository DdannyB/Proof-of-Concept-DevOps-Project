using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblTimekeepingEntryInefficiency
    {
        public long PkTimekeepingentryinefficiencyid { get; set; }
        public long FkTimekeepingentryid { get; set; }
        public long FkTimekeepinginefficientietypeid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public decimal Hrs { get; set; }

        public TblTimekeepingEntry FkTimekeepingentry { get; set; }
        public TblTimekeepingInEfficientieType FkTimekeepinginefficientietype { get; set; }
    }
}

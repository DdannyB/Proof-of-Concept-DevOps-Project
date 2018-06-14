using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblScheduleChange
    {
        public long PkSchedulechangeid { get; set; }
        public long FkSchedulechangeprojectid { get; set; }
        public long DkObjectid { get; set; }
        public string Value { get; set; }
        public int Parententitytype { get; set; }
        public long? DkParentobjectid { get; set; }
        public long? FkScopeid { get; set; }
        public long? FkSubprojectid { get; set; }

        public TblScheduleChangeProject FkSchedulechangeproject { get; set; }
        public TblScope FkScope { get; set; }
    }
}

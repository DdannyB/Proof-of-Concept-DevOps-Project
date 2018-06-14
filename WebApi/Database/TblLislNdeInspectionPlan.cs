using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblLislNdeInspectionPlan
    {
        public long PkLislndeinspectionplanid { get; set; }
        public long FkLislid { get; set; }
        public long FkNdemainid { get; set; }
        public long FkNdedeadlineid { get; set; }
        public int Locationenumvalue { get; set; }
        public int Percentage { get; set; }
        public decimal? Inspectionvalue { get; set; }
        public long? FkInspectionvalueunitofmeasurementid { get; set; }
        public string Remark { get; set; }
        public int? Sortorder { get; set; }
        public DateTime? Freezedate { get; set; }
        public long? FkFreezeuserid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblUser FkFreezeuser { get; set; }
        public TblUnitOfMeasurement FkInspectionvalueunitofmeasurement { get; set; }
        public TblLisl FkLisl { get; set; }
        public TblNdeDeadline FkNdedeadline { get; set; }
        public TblNdeMain FkNdemain { get; set; }
    }
}

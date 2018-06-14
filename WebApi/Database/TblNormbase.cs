using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblNormbase
    {
        public TblNormbase()
        {
            TblScopeJobDetailResourceEstimate = new HashSet<TblScopeJobDetailResourceEstimate>();
        }

        public long PkNormbaseid { get; set; }
        public long FkCalcgroupmainid { get; set; }
        public long FkCalcgroupsubid { get; set; }
        public string Od { get; set; }
        public string Wt { get; set; }
        public string Sched { get; set; }
        public decimal? Hours { get; set; }
        public decimal? Price { get; set; }
        public string Reftable { get; set; }
        public string Refcol { get; set; }
        public string Rev { get; set; }
        public string Normbasetype { get; set; }
        public string Normbasedescription { get; set; }
        public decimal? Minqty { get; set; }
        public decimal? Maxqty { get; set; }
        public decimal? Mindn { get; set; }
        public decimal? Maxdn { get; set; }
        public decimal? Minpn { get; set; }
        public decimal? Maxpn { get; set; }
        public decimal? Mindia { get; set; }
        public decimal? Maxdia { get; set; }
        public decimal? Minlbs { get; set; }
        public decimal? Maxlbs { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long? FkUnitofmeasurementid { get; set; }
        public long? FkDiaid { get; set; }
        public long? FkLbsid { get; set; }
        public long? FkDnid { get; set; }
        public long? FkPnid { get; set; }

        public TblCalcGroupMain FkCalcgroupmain { get; set; }
        public TblCalcGroupSub FkCalcgroupsub { get; set; }
        public TblDia FkDia { get; set; }
        public TblDn FkDn { get; set; }
        public TblLbs FkLbs { get; set; }
        public TblPn FkPn { get; set; }
        public TblUnitOfMeasurement FkUnitofmeasurement { get; set; }
        public ICollection<TblScopeJobDetailResourceEstimate> TblScopeJobDetailResourceEstimate { get; set; }
    }
}

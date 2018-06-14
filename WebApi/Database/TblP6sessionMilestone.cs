using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblP6sessionMilestone
    {
        public long PkP6sessionmilestoneid { get; set; }
        public long FkP6sessionid { get; set; }
        public int? Oldid { get; set; }
        public string Olddb { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public string Startid { get; set; }
        public string Stopid { get; set; }
        public string Sbs1 { get; set; }
        public string Sbs1descr { get; set; }
        public string Sbs2 { get; set; }
        public string Sbs1export { get; set; }
        public string Sbs2descr { get; set; }
        public string Sbs3 { get; set; }
        public string Sbs2export { get; set; }
        public string Sbs3descr { get; set; }
        public string Wbs { get; set; }
        public string Sbs3export { get; set; }
        public string Wbsdescr { get; set; }
        public string Cbs { get; set; }
        public string Wbsexport { get; set; }
        public string Cbsdescr { get; set; }
        public string Obs { get; set; }
        public string Cbsexport { get; set; }
        public string Obsdescr { get; set; }
        public string Obsexport { get; set; }
        public string Pau { get; set; }
        public string Paudescr { get; set; }
        public string Pauexport { get; set; }
        public string Relation { get; set; }
        public string Starttype { get; set; }
        public string Stoptype { get; set; }
        public int? Scopeid { get; set; }
        public int? Scopenr { get; set; }
        public string MstartSortorder { get; set; }
        public string MstartType { get; set; }
        public string MstartDescr { get; set; }
        public string MstopSortorder { get; set; }
        public string MstopType { get; set; }
        public string MstopDescr { get; set; }
        public string MstopStartfinish { get; set; }
        public string MstartStartfinish { get; set; }

        public TblP6session FkP6session { get; set; }
    }
}

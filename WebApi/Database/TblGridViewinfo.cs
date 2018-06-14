using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblGridViewinfo
    {
        public TblGridViewinfo()
        {
            TblGridAdvViewinfo = new HashSet<TblGridAdvViewinfo>();
            TblGridSummary = new HashSet<TblGridSummary>();
            TblGridViewInfoActiveGridFilterInfo = new HashSet<TblGridViewInfoActiveGridFilterInfo>();
        }

        public string Viewtype { get; set; }
        public string Keyfield { get; set; }
        public long? FkUserid { get; set; }
        public string Roserviewname { get; set; }
        public string Roserviewvalue { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long PkGridviewinfoid { get; set; }
        public bool? Readonlyview { get; set; }

        public TblUser FkUser { get; set; }
        public ICollection<TblGridAdvViewinfo> TblGridAdvViewinfo { get; set; }
        public ICollection<TblGridSummary> TblGridSummary { get; set; }
        public ICollection<TblGridViewInfoActiveGridFilterInfo> TblGridViewInfoActiveGridFilterInfo { get; set; }
    }
}

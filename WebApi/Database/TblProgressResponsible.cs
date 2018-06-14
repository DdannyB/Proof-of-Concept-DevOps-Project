using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblProgressResponsible
    {
        public long PkProgressresponsibleid { get; set; }
        public long FkProjectid { get; set; }
        public long FkProcessareaid { get; set; }
        public long FkUnitid { get; set; }
        public long FkShortcodeid { get; set; }
        public long FkContractorid { get; set; }
        public long FkResourceid { get; set; }
        public long FkUserid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long? FkObsid { get; set; }
        public long? FkWbsid { get; set; }

        public TblContractor FkContractor { get; set; }
        public TblObs FkObs { get; set; }
        public TblProcessarea FkProcessarea { get; set; }
        public TblProject FkProject { get; set; }
        public TblResource FkResource { get; set; }
        public TblShortcode FkShortcode { get; set; }
        public TblUnit FkUnit { get; set; }
        public TblUser FkUser { get; set; }
        public TblWbs FkWbs { get; set; }
    }
}

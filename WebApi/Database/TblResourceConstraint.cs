using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblResourceConstraint
    {
        public long PkResourceconstraintid { get; set; }
        public long FkProjectid { get; set; }
        public long? FkContractorid { get; set; }
        public int Resourceconstraintunits { get; set; }
        public int Resourceconstraintpriority { get; set; }
        public string Resourceconstraintconditions { get; set; }
        public int Resourceconstraintoverplan { get; set; }
        public bool Levelresource { get; set; }
        public int? Leveledunits { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long FkResourceid { get; set; }
        public string Resourceconstraintdescription { get; set; }
        public int Resourceconstraintminimumunits { get; set; }
        public bool Resourceconstraintautocalculateunitsminimum { get; set; }
        public string Averagemanpowerneeded { get; set; }
        public string Maxmanpowerperjob { get; set; }

        public TblContractor FkContractor { get; set; }
        public TblProject FkProject { get; set; }
        public TblResource FkResource { get; set; }
    }
}

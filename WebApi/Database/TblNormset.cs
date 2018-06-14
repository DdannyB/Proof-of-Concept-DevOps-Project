using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblNormset
    {
        public TblNormset()
        {
            TblCalcCorfactorGroup = new HashSet<TblCalcCorfactorGroup>();
            TblCalcGroupMain = new HashSet<TblCalcGroupMain>();
            TblCalcGroupSub = new HashSet<TblCalcGroupSub>();
            TblNormbaseMemo = new HashSet<TblNormbaseMemo>();
            TblNormsetCircumstanceCalcCorfactor = new HashSet<TblNormsetCircumstanceCalcCorfactor>();
            TblNormsetElevationCalcCorfactor = new HashSet<TblNormsetElevationCalcCorfactor>();
            TblProject = new HashSet<TblProject>();
        }

        public long PkNormsetid { get; set; }
        public string Normsetcode { get; set; }
        public string Normsetdescription { get; set; }
        public DateTime? Validfrom { get; set; }
        public DateTime? Validto { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public bool Multiplynormsetcorrectionfactors { get; set; }

        public ICollection<TblCalcCorfactorGroup> TblCalcCorfactorGroup { get; set; }
        public ICollection<TblCalcGroupMain> TblCalcGroupMain { get; set; }
        public ICollection<TblCalcGroupSub> TblCalcGroupSub { get; set; }
        public ICollection<TblNormbaseMemo> TblNormbaseMemo { get; set; }
        public ICollection<TblNormsetCircumstanceCalcCorfactor> TblNormsetCircumstanceCalcCorfactor { get; set; }
        public ICollection<TblNormsetElevationCalcCorfactor> TblNormsetElevationCalcCorfactor { get; set; }
        public ICollection<TblProject> TblProject { get; set; }
    }
}

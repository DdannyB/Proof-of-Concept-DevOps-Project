using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblCalcCorfactor
    {
        public TblCalcCorfactor()
        {
            TblCalcGroupCorfactor = new HashSet<TblCalcGroupCorfactor>();
            TblNormsetCircumstanceCalcCorfactor = new HashSet<TblNormsetCircumstanceCalcCorfactor>();
            TblNormsetElevationCalcCorfactor = new HashSet<TblNormsetElevationCalcCorfactor>();
            TblScopeJobDetailResourceEstimateCorrectionfactor = new HashSet<TblScopeJobDetailResourceEstimateCorrectionfactor>();
        }

        public long PkCalccorfactorid { get; set; }
        public long FkCalccorfactorgroupid { get; set; }
        public string Calccorfactorcode { get; set; }
        public string Calccorfactorname { get; set; }
        public decimal Calccorfactor { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblCalcCorfactorGroup FkCalccorfactorgroup { get; set; }
        public ICollection<TblCalcGroupCorfactor> TblCalcGroupCorfactor { get; set; }
        public ICollection<TblNormsetCircumstanceCalcCorfactor> TblNormsetCircumstanceCalcCorfactor { get; set; }
        public ICollection<TblNormsetElevationCalcCorfactor> TblNormsetElevationCalcCorfactor { get; set; }
        public ICollection<TblScopeJobDetailResourceEstimateCorrectionfactor> TblScopeJobDetailResourceEstimateCorrectionfactor { get; set; }
    }
}

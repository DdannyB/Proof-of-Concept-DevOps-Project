using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblElevation
    {
        public TblElevation()
        {
            TblNormsetElevationCalcCorfactor = new HashSet<TblNormsetElevationCalcCorfactor>();
            TblTemplateBlindPoint = new HashSet<TblTemplateBlindPoint>();
        }

        public long PkElevationid { get; set; }
        public string Elevationdescription { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public ICollection<TblNormsetElevationCalcCorfactor> TblNormsetElevationCalcCorfactor { get; set; }
        public ICollection<TblTemplateBlindPoint> TblTemplateBlindPoint { get; set; }
    }
}

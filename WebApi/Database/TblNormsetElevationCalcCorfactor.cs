using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblNormsetElevationCalcCorfactor
    {
        public long PkNormsetelevationcalccorfactorid { get; set; }
        public long FkNormsetid { get; set; }
        public long FkElevationid { get; set; }
        public long FkCalccorfactorid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblCalcCorfactor FkCalccorfactor { get; set; }
        public TblElevation FkElevation { get; set; }
        public TblNormset FkNormset { get; set; }
    }
}

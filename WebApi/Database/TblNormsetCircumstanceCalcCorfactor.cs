using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblNormsetCircumstanceCalcCorfactor
    {
        public long PkNormsetcircumstancecalccorfactorid { get; set; }
        public long FkNormsetid { get; set; }
        public long FkCircumstanceid { get; set; }
        public long FkCalccorfactorid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblCalcCorfactor FkCalccorfactor { get; set; }
        public TblCircumstance FkCircumstance { get; set; }
        public TblNormset FkNormset { get; set; }
    }
}

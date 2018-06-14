using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblCalcCorfactorGroup
    {
        public TblCalcCorfactorGroup()
        {
            TblCalcCorfactor = new HashSet<TblCalcCorfactor>();
        }

        public long PkCalccorfactorgroupid { get; set; }
        public long FkNormsetid { get; set; }
        public string Calccorfactorgroupcode { get; set; }
        public string Calccorfactorgroupname { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblNormset FkNormset { get; set; }
        public ICollection<TblCalcCorfactor> TblCalcCorfactor { get; set; }
    }
}

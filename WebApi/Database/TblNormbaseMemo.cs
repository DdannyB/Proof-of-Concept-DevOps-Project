using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblNormbaseMemo
    {
        public TblNormbaseMemo()
        {
            TblCalcGroupNormbaseMemo = new HashSet<TblCalcGroupNormbaseMemo>();
        }

        public long PkNormbasememoid { get; set; }
        public long FkNormsetid { get; set; }
        public string Normbasememocode { get; set; }
        public string Normbasememodescription { get; set; }
        public string Normbasetype { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblNormset FkNormset { get; set; }
        public ICollection<TblCalcGroupNormbaseMemo> TblCalcGroupNormbaseMemo { get; set; }
    }
}

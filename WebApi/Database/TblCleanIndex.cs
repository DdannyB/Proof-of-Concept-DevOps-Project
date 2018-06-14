using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblCleanIndex
    {
        public TblCleanIndex()
        {
            TblScopePolution = new HashSet<TblScopePolution>();
        }

        public long PkCleanindexid { get; set; }
        public long FkProdtypeid { get; set; }
        public long FkPoldegreeid { get; set; }
        public long FkPolgradeid { get; set; }
        public long FkPoltypeid { get; set; }
        public long FkCleancodeid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblCleanCode FkCleancode { get; set; }
        public TblPolDegree FkPoldegree { get; set; }
        public TblPolGrade FkPolgrade { get; set; }
        public TblPolType FkPoltype { get; set; }
        public TblProdType FkProdtype { get; set; }
        public ICollection<TblScopePolution> TblScopePolution { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblCategory
    {
        public TblCategory()
        {
            TblChangeRequest = new HashSet<TblChangeRequest>();
            TblLisl = new HashSet<TblLisl>();
        }

        public long PkCategoryid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public bool Iswelditcategory { get; set; }
        public bool Ischangeitcategory { get; set; }

        public ICollection<TblChangeRequest> TblChangeRequest { get; set; }
        public ICollection<TblLisl> TblLisl { get; set; }
    }
}

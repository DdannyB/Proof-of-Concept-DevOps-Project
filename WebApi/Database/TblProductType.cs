using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblProductType
    {
        public TblProductType()
        {
            TblProduct = new HashSet<TblProduct>();
        }

        public long PkProducttypeid { get; set; }
        public string Producttypecode { get; set; }
        public string Producttypedescription { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public ICollection<TblProduct> TblProduct { get; set; }
    }
}

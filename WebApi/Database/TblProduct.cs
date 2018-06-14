using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblProduct
    {
        public TblProduct()
        {
            TblPipeLineProduct = new HashSet<TblPipeLineProduct>();
            TblPlantCustom = new HashSet<TblPlantCustom>();
            TblProductSymbol = new HashSet<TblProductSymbol>();
            TblTemplateBlindPointProduct = new HashSet<TblTemplateBlindPointProduct>();
        }

        public long PkProductid { get; set; }
        public string Productcode { get; set; }
        public string Productdescription { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long? FkProducttypeid { get; set; }

        public TblProductType FkProducttype { get; set; }
        public ICollection<TblPipeLineProduct> TblPipeLineProduct { get; set; }
        public ICollection<TblPlantCustom> TblPlantCustom { get; set; }
        public ICollection<TblProductSymbol> TblProductSymbol { get; set; }
        public ICollection<TblTemplateBlindPointProduct> TblTemplateBlindPointProduct { get; set; }
    }
}

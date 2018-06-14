using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblProductSymbol
    {
        public long PkProductsymbolid { get; set; }
        public long FkProductid { get; set; }
        public long FkSymbolid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblProduct FkProduct { get; set; }
        public TblSymbol FkSymbol { get; set; }
    }
}

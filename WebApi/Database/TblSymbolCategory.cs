using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblSymbolCategory
    {
        public TblSymbolCategory()
        {
            TblSymbol = new HashSet<TblSymbol>();
        }

        public long PkSymbolcategoryid { get; set; }
        public string Symbolcategorycode { get; set; }
        public string SymbolcategorydescriptionL1 { get; set; }
        public string SymbolcategorydescriptionL2 { get; set; }
        public string SymbolcategorydescriptionL3 { get; set; }
        public string SymbolcategorydescriptionL4 { get; set; }
        public string SymbolcategorydescriptionL5 { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public ICollection<TblSymbol> TblSymbol { get; set; }
    }
}

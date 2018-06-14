using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblSymbol
    {
        public TblSymbol()
        {
            TblHazardSymbol = new HashSet<TblHazardSymbol>();
            TblProductSymbol = new HashSet<TblProductSymbol>();
        }

        public long PkSymbolid { get; set; }
        public long FkSymbolcategoryid { get; set; }
        public string Symbolcode { get; set; }
        public string SymboldescriptionL1 { get; set; }
        public string SymboldescriptionL2 { get; set; }
        public string SymboldescriptionL3 { get; set; }
        public string SymboldescriptionL4 { get; set; }
        public string SymboldescriptionL5 { get; set; }
        public byte[] Symbolimage { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblSymbolCategory FkSymbolcategory { get; set; }
        public ICollection<TblHazardSymbol> TblHazardSymbol { get; set; }
        public ICollection<TblProductSymbol> TblProductSymbol { get; set; }
    }
}

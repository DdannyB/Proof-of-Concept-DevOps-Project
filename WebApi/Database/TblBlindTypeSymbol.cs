using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblBlindTypeSymbol
    {
        public TblBlindTypeSymbol()
        {
            TblBlindType = new HashSet<TblBlindType>();
        }

        public long PkBlindtypesymbolid { get; set; }
        public string Title { get; set; }
        public byte[] Image { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public ICollection<TblBlindType> TblBlindType { get; set; }
    }
}

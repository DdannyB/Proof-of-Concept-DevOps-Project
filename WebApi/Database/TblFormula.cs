using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblFormula
    {
        public TblFormula()
        {
            TblFormulaParameter = new HashSet<TblFormulaParameter>();
        }

        public long PkFormulaid { get; set; }
        public string Formulaname { get; set; }
        public string Formula { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public ICollection<TblFormulaParameter> TblFormulaParameter { get; set; }
    }
}

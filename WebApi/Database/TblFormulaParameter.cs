using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblFormulaParameter
    {
        public TblFormulaParameter()
        {
            TblChangeRequestFormulaParameter = new HashSet<TblChangeRequestFormulaParameter>();
        }

        public long PkFormulaparameterid { get; set; }
        public long FkFormulaid { get; set; }
        public string Formulaparametername { get; set; }
        public int Formulaparameterid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblFormula FkFormula { get; set; }
        public ICollection<TblChangeRequestFormulaParameter> TblChangeRequestFormulaParameter { get; set; }
    }
}

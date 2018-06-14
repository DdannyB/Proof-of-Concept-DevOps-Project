using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblBudgetCode
    {
        public TblBudgetCode()
        {
            TblScope = new HashSet<TblScope>();
        }

        public long PkBudgetcodeid { get; set; }
        public long FkBudgettypeid { get; set; }
        public string Budgetcode { get; set; }
        public string Budgetcodedescription { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblBudgetType FkBudgettype { get; set; }
        public ICollection<TblScope> TblScope { get; set; }
    }
}

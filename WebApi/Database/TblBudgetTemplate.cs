using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblBudgetTemplate
    {
        public TblBudgetTemplate()
        {
            TblBudgetTemplateSubDiscipline = new HashSet<TblBudgetTemplateSubDiscipline>();
        }

        public long PkBudgettemplateid { get; set; }
        public long FkShortcodeid { get; set; }
        public string Templatedescription { get; set; }
        public bool Isdefault { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblShortcode FkShortcode { get; set; }
        public ICollection<TblBudgetTemplateSubDiscipline> TblBudgetTemplateSubDiscipline { get; set; }
    }
}

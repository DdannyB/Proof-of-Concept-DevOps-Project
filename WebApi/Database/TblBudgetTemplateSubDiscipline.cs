using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblBudgetTemplateSubDiscipline
    {
        public long PkBudgettemplatesubdisciplineid { get; set; }
        public long FkBudgettemplateid { get; set; }
        public long FkSubdisciplineid { get; set; }
        public string Memo { get; set; }
        public decimal? Matbudget { get; set; }
        public decimal? Manhrsbudget { get; set; }
        public decimal? Eqprentalsbudget { get; set; }
        public decimal? Crew { get; set; }
        public decimal? Durationhrs { get; set; }
        public decimal? Rate { get; set; }
        public string Oldtaskdescription { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblBudgetTemplate FkBudgettemplate { get; set; }
        public TblSubDiscipline FkSubdiscipline { get; set; }
    }
}

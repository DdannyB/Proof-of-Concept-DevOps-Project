using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblDisciplineType
    {
        public TblDisciplineType()
        {
            TblTemplateBlindPointDiscipline = new HashSet<TblTemplateBlindPointDiscipline>();
        }

        public long PkDisciplinetypeid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long FkSubdisciplineid { get; set; }

        public TblSubDiscipline FkSubdiscipline { get; set; }
        public ICollection<TblTemplateBlindPointDiscipline> TblTemplateBlindPointDiscipline { get; set; }
    }
}

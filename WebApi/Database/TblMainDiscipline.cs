using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblMainDiscipline
    {
        public TblMainDiscipline()
        {
            TblScope = new HashSet<TblScope>();
            TblSubDiscipline = new HashSet<TblSubDiscipline>();
        }

        public long PkMaindisciplineid { get; set; }
        public string Maindisciplinecode { get; set; }
        public string MaindisciplinedescriptionL1 { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public string MaindisciplinedescriptionL2 { get; set; }
        public string MaindisciplinedescriptionL3 { get; set; }
        public string MaindisciplinedescriptionL4 { get; set; }
        public string MaindisciplinedescriptionL5 { get; set; }

        public ICollection<TblScope> TblScope { get; set; }
        public ICollection<TblSubDiscipline> TblSubDiscipline { get; set; }
    }
}

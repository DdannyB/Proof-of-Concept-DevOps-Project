using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblDocumentLabelShortcodeSubDiscipline
    {
        public long PkDocumentlabelshortcodesubdisciplineid { get; set; }
        public long FkDocumentlabelid { get; set; }
        public long? FkShortcodeid { get; set; }
        public long? FkSubdisciplineid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblDocumentLabel FkDocumentlabel { get; set; }
        public TblShortcode FkShortcode { get; set; }
        public TblSubDiscipline FkSubdiscipline { get; set; }
    }
}

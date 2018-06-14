using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblBlindPointDisciplineConfirmation
    {
        public long PkBlindpointdisciplineconfirmationid { get; set; }
        public long FkTemplateblindpointdisciplineid { get; set; }
        public long FkBlindpointid { get; set; }
        public string Confirmationuser { get; set; }
        public DateTime Confirmationdate { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblBlindPoint FkBlindpoint { get; set; }
        public TblTemplateBlindPointDiscipline FkTemplateblindpointdiscipline { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblWeldProcedure
    {
        public TblWeldProcedure()
        {
            TblAttachment = new HashSet<TblAttachment>();
            TblLisl = new HashSet<TblLisl>();
            TblWeldConnection = new HashSet<TblWeldConnection>();
            TblWeldProcedureDocumentLabel = new HashSet<TblWeldProcedureDocumentLabel>();
        }

        public long PkWeldprocedureid { get; set; }
        public long? FkMaterialpipespecid { get; set; }
        public string Wpr { get; set; }
        public string Wprsub { get; set; }
        public string Description { get; set; }
        public string Rev { get; set; }
        public DateTime? Revdate { get; set; }
        public string Parta { get; set; }
        public string Partb { get; set; }
        public string Matgroup { get; set; }
        public bool? Preheat { get; set; }
        public long? Pwht { get; set; }
        public string Ht { get; set; }
        public string Us { get; set; }
        public string Mpi { get; set; }
        public string Pt { get; set; }
        public string Ndeclass { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblMaterialPipeSpec FkMaterialpipespec { get; set; }
        public ICollection<TblAttachment> TblAttachment { get; set; }
        public ICollection<TblLisl> TblLisl { get; set; }
        public ICollection<TblWeldConnection> TblWeldConnection { get; set; }
        public ICollection<TblWeldProcedureDocumentLabel> TblWeldProcedureDocumentLabel { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblFillerMaterial
    {
        public TblFillerMaterial()
        {
            TblNdeRequest = new HashSet<TblNdeRequest>();
            TblWeldConnection = new HashSet<TblWeldConnection>();
            TblWeldProcedureQualificationRecord = new HashSet<TblWeldProcedureQualificationRecord>();
            TblWeldProcedureSpecification = new HashSet<TblWeldProcedureSpecification>();
        }

        public long PkFillermaterialid { get; set; }
        public long? FkFillermaterialgroupid { get; set; }
        public string Fillermaterialdescription { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblFillerMaterialGroup FkFillermaterialgroup { get; set; }
        public ICollection<TblNdeRequest> TblNdeRequest { get; set; }
        public ICollection<TblWeldConnection> TblWeldConnection { get; set; }
        public ICollection<TblWeldProcedureQualificationRecord> TblWeldProcedureQualificationRecord { get; set; }
        public ICollection<TblWeldProcedureSpecification> TblWeldProcedureSpecification { get; set; }
    }
}

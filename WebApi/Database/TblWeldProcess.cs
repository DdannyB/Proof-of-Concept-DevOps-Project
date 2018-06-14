using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblWeldProcess
    {
        public TblWeldProcess()
        {
            TblNdeRequest = new HashSet<TblNdeRequest>();
            TblWeldConnection = new HashSet<TblWeldConnection>();
            TblWeldProcedureQualificationRecord = new HashSet<TblWeldProcedureQualificationRecord>();
            TblWeldProcedureSpecificationFkStep1weldprocess = new HashSet<TblWeldProcedureSpecification>();
            TblWeldProcedureSpecificationFkStep2weldprocess = new HashSet<TblWeldProcedureSpecification>();
            TblWeldProcedureSpecificationFkStep3weldprocess = new HashSet<TblWeldProcedureSpecification>();
        }

        public long PkWeldprocessid { get; set; }
        public string Weldprocessasmecode { get; set; }
        public string Weldprocessdescription { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public string Weldprocessenisocode { get; set; }

        public ICollection<TblNdeRequest> TblNdeRequest { get; set; }
        public ICollection<TblWeldConnection> TblWeldConnection { get; set; }
        public ICollection<TblWeldProcedureQualificationRecord> TblWeldProcedureQualificationRecord { get; set; }
        public ICollection<TblWeldProcedureSpecification> TblWeldProcedureSpecificationFkStep1weldprocess { get; set; }
        public ICollection<TblWeldProcedureSpecification> TblWeldProcedureSpecificationFkStep2weldprocess { get; set; }
        public ICollection<TblWeldProcedureSpecification> TblWeldProcedureSpecificationFkStep3weldprocess { get; set; }
    }
}

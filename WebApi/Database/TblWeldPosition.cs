using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblWeldPosition
    {
        public TblWeldPosition()
        {
            TblWeldProcedureQualificationRecord = new HashSet<TblWeldProcedureQualificationRecord>();
            TblWeldProcedureSpecification = new HashSet<TblWeldProcedureSpecification>();
        }

        public long PkWeldpositionid { get; set; }
        public string Weldpositionenisocode { get; set; }
        public string Weldpositionasmecode { get; set; }
        public string Weldpositiondescription { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public ICollection<TblWeldProcedureQualificationRecord> TblWeldProcedureQualificationRecord { get; set; }
        public ICollection<TblWeldProcedureSpecification> TblWeldProcedureSpecification { get; set; }
    }
}

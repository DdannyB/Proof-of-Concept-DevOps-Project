using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblWeldType
    {
        public TblWeldType()
        {
            TblWeldProcedureQualificationRecord = new HashSet<TblWeldProcedureQualificationRecord>();
            TblWeldProcedureSpecification = new HashSet<TblWeldProcedureSpecification>();
        }

        public long PkWeldtypeid { get; set; }
        public string Weldtypecode { get; set; }
        public string Weldtypedescription { get; set; }
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

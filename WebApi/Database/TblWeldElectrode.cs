using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblWeldElectrode
    {
        public TblWeldElectrode()
        {
            TblWeldProcedureQualificationRecord = new HashSet<TblWeldProcedureQualificationRecord>();
            TblWeldProcedureSpecification = new HashSet<TblWeldProcedureSpecification>();
        }

        public long PkWeldelectrodeid { get; set; }
        public string Weldelectrodecode { get; set; }
        public string Weldelectrodedescription { get; set; }
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

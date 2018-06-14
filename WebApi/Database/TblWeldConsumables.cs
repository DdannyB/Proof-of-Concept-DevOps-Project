using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblWeldConsumables
    {
        public TblWeldConsumables()
        {
            TblWeldProcedureQualificationRecord = new HashSet<TblWeldProcedureQualificationRecord>();
            TblWeldProcedureSpecificationFkStep1weldconsumables = new HashSet<TblWeldProcedureSpecification>();
            TblWeldProcedureSpecificationFkStep2weldconsumable = new HashSet<TblWeldProcedureSpecification>();
            TblWeldProcedureSpecificationFkStep3weldconsumable = new HashSet<TblWeldProcedureSpecification>();
        }

        public long PkWeldconsumablesid { get; set; }
        public string Weldconsumablescode { get; set; }
        public string Weldconsumablesdescription { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public ICollection<TblWeldProcedureQualificationRecord> TblWeldProcedureQualificationRecord { get; set; }
        public ICollection<TblWeldProcedureSpecification> TblWeldProcedureSpecificationFkStep1weldconsumables { get; set; }
        public ICollection<TblWeldProcedureSpecification> TblWeldProcedureSpecificationFkStep2weldconsumable { get; set; }
        public ICollection<TblWeldProcedureSpecification> TblWeldProcedureSpecificationFkStep3weldconsumable { get; set; }
    }
}

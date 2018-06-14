using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblBaseMaterialGroup
    {
        public TblBaseMaterialGroup()
        {
            TblBaseMaterial = new HashSet<TblBaseMaterial>();
            TblWeldProcedureQualificationRecordFkPartabasematerialgroup = new HashSet<TblWeldProcedureQualificationRecord>();
            TblWeldProcedureQualificationRecordFkPartbbasematerialgroup = new HashSet<TblWeldProcedureQualificationRecord>();
            TblWeldProcedureSpecificationFkPartabasematerialgroup = new HashSet<TblWeldProcedureSpecification>();
            TblWeldProcedureSpecificationFkPartbbasematerialgroup = new HashSet<TblWeldProcedureSpecification>();
        }

        public long PkBasematerialgroupid { get; set; }
        public string Basematerialgroupenisocode { get; set; }
        public string Basematerialgroupasmecode { get; set; }
        public string Basematerialgroupdescription { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public int? Basematerialgrouptype { get; set; }

        public ICollection<TblBaseMaterial> TblBaseMaterial { get; set; }
        public ICollection<TblWeldProcedureQualificationRecord> TblWeldProcedureQualificationRecordFkPartabasematerialgroup { get; set; }
        public ICollection<TblWeldProcedureQualificationRecord> TblWeldProcedureQualificationRecordFkPartbbasematerialgroup { get; set; }
        public ICollection<TblWeldProcedureSpecification> TblWeldProcedureSpecificationFkPartabasematerialgroup { get; set; }
        public ICollection<TblWeldProcedureSpecification> TblWeldProcedureSpecificationFkPartbbasematerialgroup { get; set; }
    }
}

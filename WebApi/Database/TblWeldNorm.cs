using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblWeldNorm
    {
        public TblWeldNorm()
        {
            TblBolting = new HashSet<TblBolting>();
            TblTemplateBlindPoint = new HashSet<TblTemplateBlindPoint>();
            TblWeldProcedureQualificationRecord = new HashSet<TblWeldProcedureQualificationRecord>();
            TblWeldProcedureSpecification = new HashSet<TblWeldProcedureSpecification>();
        }

        public long PkWeldnormid { get; set; }
        public string Weldnormcode { get; set; }
        public string Weldnormdescription { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public ICollection<TblBolting> TblBolting { get; set; }
        public ICollection<TblTemplateBlindPoint> TblTemplateBlindPoint { get; set; }
        public ICollection<TblWeldProcedureQualificationRecord> TblWeldProcedureQualificationRecord { get; set; }
        public ICollection<TblWeldProcedureSpecification> TblWeldProcedureSpecification { get; set; }
    }
}

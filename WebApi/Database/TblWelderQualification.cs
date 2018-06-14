using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblWelderQualification
    {
        public TblWelderQualification()
        {
            TblAttachment = new HashSet<TblAttachment>();
            TblWelderQualificationDocumentLabel = new HashSet<TblWelderQualificationDocumentLabel>();
            TblWelderQualificationRecord = new HashSet<TblWelderQualificationRecord>();
        }

        public long PkWelderqualificationid { get; set; }
        public long FkWelderid { get; set; }
        public long? FkWeldprocedurequalificationrecordid { get; set; }
        public long? FkWeldprocedurespecificationid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblWelder FkWelder { get; set; }
        public TblWeldProcedureQualificationRecord FkWeldprocedurequalificationrecord { get; set; }
        public TblWeldProcedureSpecification FkWeldprocedurespecification { get; set; }
        public ICollection<TblAttachment> TblAttachment { get; set; }
        public ICollection<TblWelderQualificationDocumentLabel> TblWelderQualificationDocumentLabel { get; set; }
        public ICollection<TblWelderQualificationRecord> TblWelderQualificationRecord { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblBranch
    {
        public TblBranch()
        {
            TblProject = new HashSet<TblProject>();
            TblWeldProcedureQualificationRecord = new HashSet<TblWeldProcedureQualificationRecord>();
            TblWelderBranch = new HashSet<TblWelderBranch>();
        }

        public long PkBranchid { get; set; }
        public string Branchcode { get; set; }
        public string Branchdescription { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public ICollection<TblProject> TblProject { get; set; }
        public ICollection<TblWeldProcedureQualificationRecord> TblWeldProcedureQualificationRecord { get; set; }
        public ICollection<TblWelderBranch> TblWelderBranch { get; set; }
    }
}

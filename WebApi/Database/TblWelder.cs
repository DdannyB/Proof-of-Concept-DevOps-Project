using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblWelder
    {
        public TblWelder()
        {
            TblNdeRequest = new HashSet<TblNdeRequest>();
            TblWeldConnectionWelder = new HashSet<TblWeldConnectionWelder>();
            TblWelderBranch = new HashSet<TblWelderBranch>();
            TblWelderProject = new HashSet<TblWelderProject>();
            TblWelderQualification = new HashSet<TblWelderQualification>();
        }

        public long PkWelderid { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long? FkContractorid { get; set; }
        public long? FkSubcontractorid { get; set; }
        public bool Isactive { get; set; }

        public TblContractor FkContractor { get; set; }
        public TblContractor FkSubcontractor { get; set; }
        public ICollection<TblNdeRequest> TblNdeRequest { get; set; }
        public ICollection<TblWeldConnectionWelder> TblWeldConnectionWelder { get; set; }
        public ICollection<TblWelderBranch> TblWelderBranch { get; set; }
        public ICollection<TblWelderProject> TblWelderProject { get; set; }
        public ICollection<TblWelderQualification> TblWelderQualification { get; set; }
    }
}

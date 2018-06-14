using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblNdeDeadline
    {
        public TblNdeDeadline()
        {
            TblLislNdeInspectionPlan = new HashSet<TblLislNdeInspectionPlan>();
            TblNdeRequest = new HashSet<TblNdeRequest>();
        }

        public long PkNdedeadline { get; set; }
        public string Ndedeadlinecode { get; set; }
        public string Ndedeadlinedescription { get; set; }
        public long? Ndedeadlinesequencenumber { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public bool Isweldinspection { get; set; }

        public ICollection<TblLislNdeInspectionPlan> TblLislNdeInspectionPlan { get; set; }
        public ICollection<TblNdeRequest> TblNdeRequest { get; set; }
    }
}

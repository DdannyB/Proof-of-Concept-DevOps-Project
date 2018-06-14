using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblNdeMain
    {
        public TblNdeMain()
        {
            TblLislNdeInspectionPlan = new HashSet<TblLislNdeInspectionPlan>();
            TblNdeRequest = new HashSet<TblNdeRequest>();
            TblNdeSub = new HashSet<TblNdeSub>();
        }

        public long PkNdemainid { get; set; }
        public string Code { get; set; }
        public string Spec { get; set; }
        public string En { get; set; }
        public string Nl { get; set; }
        public string De { get; set; }
        public string Fr { get; set; }
        public string Es { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long? FkDocumentlabelid { get; set; }

        public TblDocumentLabel FkDocumentlabel { get; set; }
        public ICollection<TblLislNdeInspectionPlan> TblLislNdeInspectionPlan { get; set; }
        public ICollection<TblNdeRequest> TblNdeRequest { get; set; }
        public ICollection<TblNdeSub> TblNdeSub { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblNdeResults
    {
        public TblNdeResults()
        {
            TblNdeRequest = new HashSet<TblNdeRequest>();
        }

        public long PkNderesultid { get; set; }
        public string Description { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public bool Isready { get; set; }
        public bool Isrepair { get; set; }
        public bool Isreexamination { get; set; }

        public ICollection<TblNdeRequest> TblNdeRequest { get; set; }
    }
}

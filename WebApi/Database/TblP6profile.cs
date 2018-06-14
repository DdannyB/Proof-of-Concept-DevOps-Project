using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblP6profile
    {
        public TblP6profile()
        {
            TblP6profileCustomField = new HashSet<TblP6profileCustomField>();
        }

        public long PkP6profileid { get; set; }
        public string P6profilename { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public ICollection<TblP6profileCustomField> TblP6profileCustomField { get; set; }
    }
}

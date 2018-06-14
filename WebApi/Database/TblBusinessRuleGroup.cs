using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblBusinessRuleGroup
    {
        public TblBusinessRuleGroup()
        {
            TblBusinessRule = new HashSet<TblBusinessRule>();
        }

        public long PkBusinessrulegroupid { get; set; }
        public int Businessrulegroupid { get; set; }
        public bool? Isactive { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public ICollection<TblBusinessRule> TblBusinessRule { get; set; }
    }
}

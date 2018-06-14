using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblP6customField
    {
        public TblP6customField()
        {
            TblP6profileCustomField = new HashSet<TblP6profileCustomField>();
        }

        public long PkP6customfieldid { get; set; }
        public string P6customfieldcode { get; set; }
        public string P6customfielddescription { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public int P6customfieldexportlevel { get; set; }

        public ICollection<TblP6profileCustomField> TblP6profileCustomField { get; set; }
    }
}

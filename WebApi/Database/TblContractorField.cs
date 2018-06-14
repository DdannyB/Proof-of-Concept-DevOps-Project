using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblContractorField
    {
        public TblContractorField()
        {
            TblUserContractorField = new HashSet<TblUserContractorField>();
        }

        public long PkContractorfieldid { get; set; }
        public long FkContractorid { get; set; }
        public string Fieldname { get; set; }
        public string Fielddescription { get; set; }
        public int Fieldtypeenumvalue { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblContractor FkContractor { get; set; }
        public ICollection<TblUserContractorField> TblUserContractorField { get; set; }
    }
}

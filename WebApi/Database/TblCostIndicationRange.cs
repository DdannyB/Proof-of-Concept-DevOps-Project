using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblCostIndicationRange
    {
        public TblCostIndicationRange()
        {
            TblChangeRequest = new HashSet<TblChangeRequest>();
            TblScope = new HashSet<TblScope>();
        }

        public long PkCostindicationrangeid { get; set; }
        public string Constindicationrangedescription { get; set; }
        public long Minvalue { get; set; }
        public long Maxvalue { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public int? Moctype { get; set; }
        public bool? Isscopeitindicationrange { get; set; }
        public bool? Ischangeitindicationrange { get; set; }

        public ICollection<TblChangeRequest> TblChangeRequest { get; set; }
        public ICollection<TblScope> TblScope { get; set; }
    }
}

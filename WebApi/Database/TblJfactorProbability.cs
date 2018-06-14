using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblJfactorProbability
    {
        public long PkJfactorprobabilityid { get; set; }
        public string Jfactorprobabilitydescription { get; set; }
        public int Jfactorprobabilitypercentage { get; set; }
        public decimal Score { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
    }
}

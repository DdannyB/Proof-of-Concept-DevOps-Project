using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblJfactorEffect
    {
        public long PkJfactoreffectid { get; set; }
        public string Personeldescription { get; set; }
        public string Damagedescription { get; set; }
        public string Environmentdescription { get; set; }
        public string Reputationdescription { get; set; }
        public long Costs { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
    }
}

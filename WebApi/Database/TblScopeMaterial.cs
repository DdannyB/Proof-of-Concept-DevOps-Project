using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblScopeMaterial
    {
        public long PkScopematerialid { get; set; }
        public long FkScopeid { get; set; }
        public long? FkMaterialid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long? FkScopejobdetailresourcematerialid { get; set; }

        public TblMaterial FkMaterial { get; set; }
        public TblScope FkScope { get; set; }
        public TblScopeJobDetailResourceMaterial FkScopejobdetailresourcematerial { get; set; }
    }
}

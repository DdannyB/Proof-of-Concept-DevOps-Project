using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblScopeJobDetailResourceMaterial
    {
        public TblScopeJobDetailResourceMaterial()
        {
            TblBlindPointActivityMaterial = new HashSet<TblBlindPointActivityMaterial>();
            TblScopeMaterial = new HashSet<TblScopeMaterial>();
        }

        public long PkScopejobdetailresourcematerialid { get; set; }
        public long FkScopejobdetailresourceid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long? FkMaterialid { get; set; }

        public TblMaterial FkMaterial { get; set; }
        public TblScopeJobDetailResource FkScopejobdetailresource { get; set; }
        public ICollection<TblBlindPointActivityMaterial> TblBlindPointActivityMaterial { get; set; }
        public ICollection<TblScopeMaterial> TblScopeMaterial { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblMainMaterialGroup
    {
        public TblMainMaterialGroup()
        {
            TblMaterial = new HashSet<TblMaterial>();
            TblSubMaterialGroup = new HashSet<TblSubMaterialGroup>();
        }

        public long PkMainmaterialgroupid { get; set; }
        public string Mainmatgroupcode { get; set; }
        public string MainmaterialgroupdescriptionL1 { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public string MainmaterialgroupdescriptionL2 { get; set; }
        public string MainmaterialgroupdescriptionL3 { get; set; }
        public string MainmaterialgroupdescriptionL4 { get; set; }
        public string MainmaterialgroupdescriptionL5 { get; set; }

        public ICollection<TblMaterial> TblMaterial { get; set; }
        public ICollection<TblSubMaterialGroup> TblSubMaterialGroup { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblSubMaterialGroup
    {
        public TblSubMaterialGroup()
        {
            TblBlindTypeNormPosActivityTemplateMaterial = new HashSet<TblBlindTypeNormPosActivityTemplateMaterial>();
            TblMaterial = new HashSet<TblMaterial>();
            TblMaterialLibrary = new HashSet<TblMaterialLibrary>();
        }

        public long PkSubmaterialgroupid { get; set; }
        public string Submatgroupcode { get; set; }
        public string SubmaterialgroupdescriptionL1 { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long FkMainmaterialgroupid { get; set; }
        public string SubmaterialgroupdescriptionL2 { get; set; }
        public string SubmaterialgroupdescriptionL3 { get; set; }
        public string SubmaterialgroupdescriptionL4 { get; set; }
        public string SubmaterialgroupdescriptionL5 { get; set; }

        public TblMainMaterialGroup FkMainmaterialgroup { get; set; }
        public ICollection<TblBlindTypeNormPosActivityTemplateMaterial> TblBlindTypeNormPosActivityTemplateMaterial { get; set; }
        public ICollection<TblMaterial> TblMaterial { get; set; }
        public ICollection<TblMaterialLibrary> TblMaterialLibrary { get; set; }
    }
}

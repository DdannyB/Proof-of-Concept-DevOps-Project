using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblMainToolsAndConsumablesGroup
    {
        public TblMainToolsAndConsumablesGroup()
        {
            TblSubToolsAndConsumablesGroup = new HashSet<TblSubToolsAndConsumablesGroup>();
        }

        public long PkMaintoolsandconsumablesgroupid { get; set; }
        public string Maintoolsandconsumablesgroupcode { get; set; }
        public string MaintoolsandconsumablesgroupdescriptionL1 { get; set; }
        public string MaintoolsandconsumablesgroupdescriptionL2 { get; set; }
        public string MaintoolsandconsumablesgroupdescriptionL3 { get; set; }
        public string MaintoolsandconsumablesgroupdescriptionL4 { get; set; }
        public string MaintoolsandconsumablesgroupdescriptionL5 { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public ICollection<TblSubToolsAndConsumablesGroup> TblSubToolsAndConsumablesGroup { get; set; }
    }
}

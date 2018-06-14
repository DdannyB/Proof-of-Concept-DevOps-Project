using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblSubToolsAndConsumablesGroup
    {
        public TblSubToolsAndConsumablesGroup()
        {
            TblToolsAndConsumables = new HashSet<TblToolsAndConsumables>();
        }

        public long PkSubtoolsandconsumablesgroupid { get; set; }
        public long FkMaintoolsandconsumablesgroupid { get; set; }
        public string Subtoolsandconsumablesgroupcode { get; set; }
        public string SubtoolsandconsumablesgroupdescriptionL1 { get; set; }
        public string SubtoolsandconsumablesgroupdescriptionL2 { get; set; }
        public string SubtoolsandconsumablesgroupdescriptionL3 { get; set; }
        public string SubtoolsandconsumablesgroupdescriptionL4 { get; set; }
        public string SubtoolsandconsumablesgroupdescriptionL5 { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblMainToolsAndConsumablesGroup FkMaintoolsandconsumablesgroup { get; set; }
        public ICollection<TblToolsAndConsumables> TblToolsAndConsumables { get; set; }
    }
}

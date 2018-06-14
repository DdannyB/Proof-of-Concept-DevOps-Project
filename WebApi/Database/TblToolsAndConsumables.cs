using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblToolsAndConsumables
    {
        public TblToolsAndConsumables()
        {
            TblScopeJobDetailResourceToolsAndConsumables = new HashSet<TblScopeJobDetailResourceToolsAndConsumables>();
        }

        public long PkToolsandconsumablesid { get; set; }
        public long? FkUnitofmeasurementid { get; set; }
        public string ToolsandconsumablesdescriptionL1 { get; set; }
        public string Capacity { get; set; }
        public string Extra { get; set; }
        public string Sw { get; set; }
        public string Nm { get; set; }
        public string Notes { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public string Articlenr { get; set; }
        public string ToolsandconsumablesdescriptionL2 { get; set; }
        public string ToolsandconsumablesdescriptionL3 { get; set; }
        public string ToolsandconsumablesdescriptionL4 { get; set; }
        public string ToolsandconsumablesdescriptionL5 { get; set; }
        public decimal? Price { get; set; }
        public long? FkSubtoolsandconsumablesgroupid { get; set; }
        public long? FkContractorid { get; set; }
        public bool Iscustom { get; set; }

        public TblContractor FkContractor { get; set; }
        public TblSubToolsAndConsumablesGroup FkSubtoolsandconsumablesgroup { get; set; }
        public TblUnitOfMeasurement FkUnitofmeasurement { get; set; }
        public ICollection<TblScopeJobDetailResourceToolsAndConsumables> TblScopeJobDetailResourceToolsAndConsumables { get; set; }
    }
}

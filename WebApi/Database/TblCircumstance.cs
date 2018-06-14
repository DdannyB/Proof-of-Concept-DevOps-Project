using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblCircumstance
    {
        public TblCircumstance()
        {
            TblBasePermitMaintenanceStrategyDetails = new HashSet<TblBasePermitMaintenanceStrategyDetails>();
            TblBlindPointActivityCircumstance = new HashSet<TblBlindPointActivityCircumstance>();
            TblNormsetCircumstanceCalcCorfactor = new HashSet<TblNormsetCircumstanceCalcCorfactor>();
            TblScopeJobDetailResourceCircumstance = new HashSet<TblScopeJobDetailResourceCircumstance>();
            TblTemplateBlindPointActivityCircumstance = new HashSet<TblTemplateBlindPointActivityCircumstance>();
            TblTimekeepingEntryCircum = new HashSet<TblTimekeepingEntryCircum>();
        }

        public long PkCircumstanceid { get; set; }
        public string Circumstancecode { get; set; }
        public string CircumstancedescriptionL1 { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public string CircumstancedescriptionL2 { get; set; }
        public string CircumstancedescriptionL3 { get; set; }
        public string CircumstancedescriptionL4 { get; set; }
        public string CircumstancedescriptionL5 { get; set; }
        public byte[] Circumstanceimage { get; set; }

        public ICollection<TblBasePermitMaintenanceStrategyDetails> TblBasePermitMaintenanceStrategyDetails { get; set; }
        public ICollection<TblBlindPointActivityCircumstance> TblBlindPointActivityCircumstance { get; set; }
        public ICollection<TblNormsetCircumstanceCalcCorfactor> TblNormsetCircumstanceCalcCorfactor { get; set; }
        public ICollection<TblScopeJobDetailResourceCircumstance> TblScopeJobDetailResourceCircumstance { get; set; }
        public ICollection<TblTemplateBlindPointActivityCircumstance> TblTemplateBlindPointActivityCircumstance { get; set; }
        public ICollection<TblTimekeepingEntryCircum> TblTimekeepingEntryCircum { get; set; }
    }
}

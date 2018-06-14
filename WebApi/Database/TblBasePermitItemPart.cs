using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblBasePermitItemPart
    {
        public TblBasePermitItemPart()
        {
            TblAttachment = new HashSet<TblAttachment>();
            TblBasePermitItemPartDocumentLabel = new HashSet<TblBasePermitItemPartDocumentLabel>();
            TblBasePermitItemPartPermitQuickFilter = new HashSet<TblBasePermitItemPartPermitQuickFilter>();
            TblBasePermitMaintenanceStrategyBasePermitItemPart = new HashSet<TblBasePermitMaintenanceStrategyBasePermitItemPart>();
            TblBasePermitTriggerBasePermitItemPart = new HashSet<TblBasePermitTriggerBasePermitItemPart>();
            TblPermitItemPart = new HashSet<TblPermitItemPart>();
        }

        public long PkBasepermititempartid { get; set; }
        public long FkBasepermititemid { get; set; }
        public int Basepermititemparttype { get; set; }
        public string Textvalue { get; set; }
        public double Xpos { get; set; }
        public double Ypos { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long? DkDatadrivenforeignkey { get; set; }
        public int? Basepermititempartsubtype { get; set; }
        public bool? Islinked { get; set; }
        public int? Signaturestamptype { get; set; }
        public int? Stampandsignatureposition { get; set; }

        public TblBasePermitItem FkBasepermititem { get; set; }
        public ICollection<TblAttachment> TblAttachment { get; set; }
        public ICollection<TblBasePermitItemPartDocumentLabel> TblBasePermitItemPartDocumentLabel { get; set; }
        public ICollection<TblBasePermitItemPartPermitQuickFilter> TblBasePermitItemPartPermitQuickFilter { get; set; }
        public ICollection<TblBasePermitMaintenanceStrategyBasePermitItemPart> TblBasePermitMaintenanceStrategyBasePermitItemPart { get; set; }
        public ICollection<TblBasePermitTriggerBasePermitItemPart> TblBasePermitTriggerBasePermitItemPart { get; set; }
        public ICollection<TblPermitItemPart> TblPermitItemPart { get; set; }
    }
}

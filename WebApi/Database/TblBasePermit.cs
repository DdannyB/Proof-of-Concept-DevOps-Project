using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblBasePermit
    {
        public TblBasePermit()
        {
            TblBasePermitAuthorization = new HashSet<TblBasePermitAuthorization>();
            TblBasePermitGroup = new HashSet<TblBasePermitGroup>();
            TblBasePermitMaintenanceStrategy = new HashSet<TblBasePermitMaintenanceStrategy>();
            TblBasePermitTrigger = new HashSet<TblBasePermitTrigger>();
            TblBasePermitTriggered = new HashSet<TblBasePermitTriggered>();
            TblLibraryScopeTemplateJobBasePermit = new HashSet<TblLibraryScopeTemplateJobBasePermit>();
            TblPermit = new HashSet<TblPermit>();
        }

        public long PkBasepermitid { get; set; }
        public string Basepermitname { get; set; }
        public DateTime? Inactivedate { get; set; }
        public DateTime? Freezedate { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public int Paperkind { get; set; }
        public bool Landscape { get; set; }
        public long FkWorkflowid { get; set; }
        public string Basepermitprintername { get; set; }
        public bool Selectbasepermitprinteronthefly { get; set; }
        public string Attachmentprintername { get; set; }
        public bool Selectattachmentprinteronthefly { get; set; }
        public string Freezeuser { get; set; }
        public int? Indexlistpaperkind { get; set; }
        public short? Issuecount { get; set; }
        public string Indexlistprintername { get; set; }
        public bool Selectindexlistprinteronthefly { get; set; }
        public int Basepermitheaderheight { get; set; }
        public int Basepermitfooterheight { get; set; }
        public int Basepermittype { get; set; }
        public byte[] Documenticon { get; set; }
        public string Basedocumentprintername { get; set; }
        public bool Selectbasedocumentprinteronthefly { get; set; }

        public TblWorkflow FkWorkflow { get; set; }
        public ICollection<TblBasePermitAuthorization> TblBasePermitAuthorization { get; set; }
        public ICollection<TblBasePermitGroup> TblBasePermitGroup { get; set; }
        public ICollection<TblBasePermitMaintenanceStrategy> TblBasePermitMaintenanceStrategy { get; set; }
        public ICollection<TblBasePermitTrigger> TblBasePermitTrigger { get; set; }
        public ICollection<TblBasePermitTriggered> TblBasePermitTriggered { get; set; }
        public ICollection<TblLibraryScopeTemplateJobBasePermit> TblLibraryScopeTemplateJobBasePermit { get; set; }
        public ICollection<TblPermit> TblPermit { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblPropackExport
    {
        public TblPropackExport()
        {
            TblPropackExportDeliverable = new HashSet<TblPropackExportDeliverable>();
            TblPropackExportLog = new HashSet<TblPropackExportLog>();
            TblPropackExportResource = new HashSet<TblPropackExportResource>();
            TblPropackExportSent = new HashSet<TblPropackExportSent>();
        }

        public long PkPropackexportid { get; set; }
        public long FkPropackid { get; set; }
        public int? Oldid { get; set; }
        public string Olddb { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public int Propackexportnr { get; set; }
        public DateTime? Duedate { get; set; }
        public bool Allowcrewedit { get; set; }
        public bool Allowdurationedit { get; set; }
        public bool Allowresmemoedit { get; set; }
        public bool? Includewpholdermemo { get; set; }
        public bool? Includeshememo { get; set; }
        public bool? Showcompletetree { get; set; }
        public int Defaultpricetype { get; set; }
        public bool Allowpricetypeoverride { get; set; }
        public int Propackexportstate { get; set; }
        public string Freezeusername { get; set; }
        public DateTime? Freezedate { get; set; }
        public string Propackexportusername { get; set; }
        public bool Iswarningresourceadded { get; set; }
        public int? Warningresourceaddedcount { get; set; }
        public bool Iswarningresourcedeleted { get; set; }
        public int? Warningresourcedeletedcount { get; set; }
        public bool Iswarningrevision { get; set; }
        public int? Warningrevisioncount { get; set; }
        public bool Iswarningduedate { get; set; }
        public int? Warningduedatecount { get; set; }

        public TblPropack FkPropack { get; set; }
        public ICollection<TblPropackExportDeliverable> TblPropackExportDeliverable { get; set; }
        public ICollection<TblPropackExportLog> TblPropackExportLog { get; set; }
        public ICollection<TblPropackExportResource> TblPropackExportResource { get; set; }
        public ICollection<TblPropackExportSent> TblPropackExportSent { get; set; }
    }
}

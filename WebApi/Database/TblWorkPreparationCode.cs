using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblWorkPreparationCode
    {
        public TblWorkPreparationCode()
        {
            TblScopeWpcode = new HashSet<TblScopeWpcode>();
            TblShortcodeTemplateWpcode = new HashSet<TblShortcodeTemplateWpcode>();
            TblUserMemberWpcode = new HashSet<TblUserMemberWpcode>();
        }

        public long PkWorkpreparationcodeid { get; set; }
        public long FkProjectid { get; set; }
        public long FkWorkpreparationphaseid { get; set; }
        public string Workpreparationcodecode { get; set; }
        public string Workpreparationcodedescription { get; set; }
        public bool Setrfcstampwp00 { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblProject FkProject { get; set; }
        public TblWorkPreparationPhase FkWorkpreparationphase { get; set; }
        public ICollection<TblScopeWpcode> TblScopeWpcode { get; set; }
        public ICollection<TblShortcodeTemplateWpcode> TblShortcodeTemplateWpcode { get; set; }
        public ICollection<TblUserMemberWpcode> TblUserMemberWpcode { get; set; }
    }
}

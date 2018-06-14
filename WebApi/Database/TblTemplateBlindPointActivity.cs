using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblTemplateBlindPointActivity
    {
        public TblTemplateBlindPointActivity()
        {
            TblTemplateBlindPointActivityChecklist = new HashSet<TblTemplateBlindPointActivityChecklist>();
            TblTemplateBlindPointActivityCircumstance = new HashSet<TblTemplateBlindPointActivityCircumstance>();
            TblTemplateBlindpointActivityMaterial = new HashSet<TblTemplateBlindpointActivityMaterial>();
        }

        public long PkTemplateblindpointactivityid { get; set; }
        public long FkTemplateblindpointid { get; set; }
        public long? FkBlindtypeid { get; set; }
        public long? FkThicknessid { get; set; }
        public long FkActivityid { get; set; }
        public int Actionby { get; set; }
        public string Memo { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public bool Needspreqc { get; set; }
        public long? FkGaskettypeid { get; set; }
        public long? FkBolttypeid { get; set; }
        public long FkMainphaseid { get; set; }
        public long FkSubphaseid { get; set; }
        public string Grouping { get; set; }
        public int Seqno { get; set; }
        public long? FkDiaid { get; set; }
        public long? FkLbsid { get; set; }
        public long? FkDnid { get; set; }
        public long? FkPnid { get; set; }
        public bool Needspostqc { get; set; }
        public bool Needsvisualqc { get; set; }
        public bool Needsfinalqc { get; set; }

        public TblActivity FkActivity { get; set; }
        public TblBlindType FkBlindtype { get; set; }
        public TblBoltType FkBolttype { get; set; }
        public TblDia FkDia { get; set; }
        public TblDn FkDn { get; set; }
        public TblGasketType FkGaskettype { get; set; }
        public TblLbs FkLbs { get; set; }
        public TblMainPhase FkMainphase { get; set; }
        public TblPn FkPn { get; set; }
        public TblSubPhase FkSubphase { get; set; }
        public TblTemplateBlindPoint FkTemplateblindpoint { get; set; }
        public TblThickness FkThickness { get; set; }
        public ICollection<TblTemplateBlindPointActivityChecklist> TblTemplateBlindPointActivityChecklist { get; set; }
        public ICollection<TblTemplateBlindPointActivityCircumstance> TblTemplateBlindPointActivityCircumstance { get; set; }
        public ICollection<TblTemplateBlindpointActivityMaterial> TblTemplateBlindpointActivityMaterial { get; set; }
    }
}

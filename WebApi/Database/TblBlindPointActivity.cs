using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblBlindPointActivity
    {
        public TblBlindPointActivity()
        {
            TblBlindPointActivityChecklist = new HashSet<TblBlindPointActivityChecklist>();
            TblBlindPointActivityCircumstance = new HashSet<TblBlindPointActivityCircumstance>();
            TblBlindPointActivityLabel = new HashSet<TblBlindPointActivityLabel>();
            TblBlindPointActivityMaterial = new HashSet<TblBlindPointActivityMaterial>();
            TblIsolationActivityRevertReason = new HashSet<TblIsolationActivityRevertReason>();
        }

        public long PkBlindpointactivityid { get; set; }
        public long FkBlindpointid { get; set; }
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
        public DateTime? Readydate { get; set; }
        public bool Needspreqc { get; set; }
        public DateTime? Preqcdate { get; set; }
        public long? FkGaskettypeid { get; set; }
        public long? FkBolttypeid { get; set; }
        public string Preqcuser { get; set; }
        public string Readyuser { get; set; }
        public bool? Preqcbybarcode { get; set; }
        public bool? Readybybarcode { get; set; }
        public long FkMainphaseid { get; set; }
        public long FkSubphaseid { get; set; }
        public string Grouping { get; set; }
        public int Seqno { get; set; }
        public long? FkContractorid { get; set; }
        public long? FkUserid { get; set; }
        public long? FkDiaid { get; set; }
        public long? FkLbsid { get; set; }
        public long? FkDnid { get; set; }
        public long? FkPnid { get; set; }
        public bool Needspostqc { get; set; }
        public DateTime? Postqcdate { get; set; }
        public string Postqcuser { get; set; }
        public bool? Postqcbybarcode { get; set; }
        public string Visualqcuser { get; set; }
        public DateTime? Visualqcdate { get; set; }
        public bool? Visualqcbybarcode { get; set; }
        public string Releaseuser { get; set; }
        public DateTime? Releasedate { get; set; }
        public bool? Releasebybarcode { get; set; }
        public bool Needsvisualqc { get; set; }
        public bool Needsfinalqc { get; set; }
        public DateTime? Finalqcdate { get; set; }
        public string Finalqcuser { get; set; }
        public bool? Finalqcbybarcode { get; set; }
        public DateTime? Notapplicabledate { get; set; }
        public string Notapplicableuser { get; set; }
        public string Notapplicablereason { get; set; }
        public int Readytype { get; set; }
        public DateTime? Startwork { get; set; }
        public string Startworkuser { get; set; }

        public TblActivity FkActivity { get; set; }
        public TblBlindPoint FkBlindpoint { get; set; }
        public TblBlindType FkBlindtype { get; set; }
        public TblBoltType FkBolttype { get; set; }
        public TblContractor FkContractor { get; set; }
        public TblDia FkDia { get; set; }
        public TblDn FkDn { get; set; }
        public TblGasketType FkGaskettype { get; set; }
        public TblLbs FkLbs { get; set; }
        public TblMainPhase FkMainphase { get; set; }
        public TblPn FkPn { get; set; }
        public TblSubPhase FkSubphase { get; set; }
        public TblThickness FkThickness { get; set; }
        public TblUser FkUser { get; set; }
        public ICollection<TblBlindPointActivityChecklist> TblBlindPointActivityChecklist { get; set; }
        public ICollection<TblBlindPointActivityCircumstance> TblBlindPointActivityCircumstance { get; set; }
        public ICollection<TblBlindPointActivityLabel> TblBlindPointActivityLabel { get; set; }
        public ICollection<TblBlindPointActivityMaterial> TblBlindPointActivityMaterial { get; set; }
        public ICollection<TblIsolationActivityRevertReason> TblIsolationActivityRevertReason { get; set; }
    }
}

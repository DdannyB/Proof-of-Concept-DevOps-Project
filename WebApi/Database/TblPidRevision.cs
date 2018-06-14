using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblPidRevision
    {
        public TblPidRevision()
        {
            TblAttachment = new HashSet<TblAttachment>();
            TblBlindlistPidRevision = new HashSet<TblBlindlistPidRevision>();
            TblPidRevisionLine = new HashSet<TblPidRevisionLine>();
            TblPidRevisionMemo = new HashSet<TblPidRevisionMemo>();
            TblPidRevisionPipeLine = new HashSet<TblPidRevisionPipeLine>();
            TblPidRevisionTemplateBlindPoint = new HashSet<TblPidRevisionTemplateBlindPoint>();
            TblPlantDataPidFkEndpidrevision = new HashSet<TblPlantDataPid>();
            TblPlantDataPidFkStartpidrevision = new HashSet<TblPlantDataPid>();
            TblScopePidRevision = new HashSet<TblScopePidRevision>();
        }

        public long PkPidrevisionid { get; set; }
        public long FkPidid { get; set; }
        public string Pidrevisionname { get; set; }
        public int Pidrevisionno { get; set; }
        public long? FkUserid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public float Pidrevisionfontsize { get; set; }
        public string Pidrevisionfontfamily { get; set; }
        public int Pidrevisionlinewidth { get; set; }
        public int Pidrevisionlinecolor { get; set; }

        public TblPid FkPid { get; set; }
        public TblUser FkUser { get; set; }
        public ICollection<TblAttachment> TblAttachment { get; set; }
        public ICollection<TblBlindlistPidRevision> TblBlindlistPidRevision { get; set; }
        public ICollection<TblPidRevisionLine> TblPidRevisionLine { get; set; }
        public ICollection<TblPidRevisionMemo> TblPidRevisionMemo { get; set; }
        public ICollection<TblPidRevisionPipeLine> TblPidRevisionPipeLine { get; set; }
        public ICollection<TblPidRevisionTemplateBlindPoint> TblPidRevisionTemplateBlindPoint { get; set; }
        public ICollection<TblPlantDataPid> TblPlantDataPidFkEndpidrevision { get; set; }
        public ICollection<TblPlantDataPid> TblPlantDataPidFkStartpidrevision { get; set; }
        public ICollection<TblScopePidRevision> TblScopePidRevision { get; set; }
    }
}

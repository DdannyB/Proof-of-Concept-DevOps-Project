using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblMainPhase
    {
        public TblMainPhase()
        {
            TblBasePermitMaintenanceStrategyDetails = new HashSet<TblBasePermitMaintenanceStrategyDetails>();
            TblBlindListReportColumn = new HashSet<TblBlindListReportColumn>();
            TblBlindPointActivity = new HashSet<TblBlindPointActivity>();
            TblBlindProjectMainPhaseSubPhaseReleaseFinish = new HashSet<TblBlindProjectMainPhaseSubPhaseReleaseFinish>();
            TblBlindTypeNormPosActivityNormbase = new HashSet<TblBlindTypeNormPosActivityNormbase>();
            TblBlindTypeNormPosActivityTemplate = new HashSet<TblBlindTypeNormPosActivityTemplate>();
            TblJobData = new HashSet<TblJobData>();
            TblQaqcQuicklist = new HashSet<TblQaqcQuicklist>();
            TblScope = new HashSet<TblScope>();
            TblTemplateBlindPointActivity = new HashSet<TblTemplateBlindPointActivity>();
            TblWallpaperDynamicColDetail = new HashSet<TblWallpaperDynamicColDetail>();
            TblWallpaperIsolationCol = new HashSet<TblWallpaperIsolationCol>();
            TblWallpaperMainPhase = new HashSet<TblWallpaperMainPhase>();
        }

        public long PkMainphaseid { get; set; }
        public string Mainphasecode { get; set; }
        public string MainphasedescriptionL1 { get; set; }
        public int Mainphasecolor { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public string MainphasedescriptionL2 { get; set; }
        public string MainphasedescriptionL3 { get; set; }
        public string MainphasedescriptionL4 { get; set; }
        public string MainphasedescriptionL5 { get; set; }
        public int Phaserastype { get; set; }

        public ICollection<TblBasePermitMaintenanceStrategyDetails> TblBasePermitMaintenanceStrategyDetails { get; set; }
        public ICollection<TblBlindListReportColumn> TblBlindListReportColumn { get; set; }
        public ICollection<TblBlindPointActivity> TblBlindPointActivity { get; set; }
        public ICollection<TblBlindProjectMainPhaseSubPhaseReleaseFinish> TblBlindProjectMainPhaseSubPhaseReleaseFinish { get; set; }
        public ICollection<TblBlindTypeNormPosActivityNormbase> TblBlindTypeNormPosActivityNormbase { get; set; }
        public ICollection<TblBlindTypeNormPosActivityTemplate> TblBlindTypeNormPosActivityTemplate { get; set; }
        public ICollection<TblJobData> TblJobData { get; set; }
        public ICollection<TblQaqcQuicklist> TblQaqcQuicklist { get; set; }
        public ICollection<TblScope> TblScope { get; set; }
        public ICollection<TblTemplateBlindPointActivity> TblTemplateBlindPointActivity { get; set; }
        public ICollection<TblWallpaperDynamicColDetail> TblWallpaperDynamicColDetail { get; set; }
        public ICollection<TblWallpaperIsolationCol> TblWallpaperIsolationCol { get; set; }
        public ICollection<TblWallpaperMainPhase> TblWallpaperMainPhase { get; set; }
    }
}

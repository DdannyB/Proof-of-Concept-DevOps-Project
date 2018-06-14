using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblSubPhase
    {
        public TblSubPhase()
        {
            TblBasePermitMaintenanceStrategyDetails = new HashSet<TblBasePermitMaintenanceStrategyDetails>();
            TblBlindListReportColumn = new HashSet<TblBlindListReportColumn>();
            TblBlindPointActivity = new HashSet<TblBlindPointActivity>();
            TblBlindProjectMainPhaseSubPhaseReleaseFinish = new HashSet<TblBlindProjectMainPhaseSubPhaseReleaseFinish>();
            TblBlindTypeNormPosActivityNormbase = new HashSet<TblBlindTypeNormPosActivityNormbase>();
            TblBlindTypeNormPosActivityTemplate = new HashSet<TblBlindTypeNormPosActivityTemplate>();
            TblJobData = new HashSet<TblJobData>();
            TblQaqcQuicklist = new HashSet<TblQaqcQuicklist>();
            TblTemplateBlindPointActivity = new HashSet<TblTemplateBlindPointActivity>();
            TblWallpaperDynamicColDetail = new HashSet<TblWallpaperDynamicColDetail>();
            TblWallpaperIsolationCol = new HashSet<TblWallpaperIsolationCol>();
        }

        public long PkSubphaseid { get; set; }
        public string Subphasecode { get; set; }
        public string SubphasedescriptionL1 { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public string SubphasedescriptionL2 { get; set; }
        public string SubphasedescriptionL3 { get; set; }
        public string SubphasedescriptionL4 { get; set; }
        public string SubphasedescriptionL5 { get; set; }

        public ICollection<TblBasePermitMaintenanceStrategyDetails> TblBasePermitMaintenanceStrategyDetails { get; set; }
        public ICollection<TblBlindListReportColumn> TblBlindListReportColumn { get; set; }
        public ICollection<TblBlindPointActivity> TblBlindPointActivity { get; set; }
        public ICollection<TblBlindProjectMainPhaseSubPhaseReleaseFinish> TblBlindProjectMainPhaseSubPhaseReleaseFinish { get; set; }
        public ICollection<TblBlindTypeNormPosActivityNormbase> TblBlindTypeNormPosActivityNormbase { get; set; }
        public ICollection<TblBlindTypeNormPosActivityTemplate> TblBlindTypeNormPosActivityTemplate { get; set; }
        public ICollection<TblJobData> TblJobData { get; set; }
        public ICollection<TblQaqcQuicklist> TblQaqcQuicklist { get; set; }
        public ICollection<TblTemplateBlindPointActivity> TblTemplateBlindPointActivity { get; set; }
        public ICollection<TblWallpaperDynamicColDetail> TblWallpaperDynamicColDetail { get; set; }
        public ICollection<TblWallpaperIsolationCol> TblWallpaperIsolationCol { get; set; }
    }
}

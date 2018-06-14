using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblWorkPreparationPhase
    {
        public TblWorkPreparationPhase()
        {
            TblForecastUsersQtyWeek = new HashSet<TblForecastUsersQtyWeek>();
            TblForecastWpphases = new HashSet<TblForecastWpphases>();
            TblScopeWpphaseProgress = new HashSet<TblScopeWpphaseProgress>();
            TblWorkPreparationCode = new HashSet<TblWorkPreparationCode>();
        }

        public long PkWorkpreparationphaseid { get; set; }
        public long FkProjectid { get; set; }
        public string Workpreparationphasenumber { get; set; }
        public string Workpreparationphasedescription { get; set; }
        public int Workpreparationphaseweightfactor { get; set; }
        public DateTime? Workpreparationphasestartdate { get; set; }
        public DateTime? Workpreparationphaseenddate { get; set; }
        public bool Isautofreeze { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public bool Isautoexporttoscheduleit { get; set; }

        public TblProject FkProject { get; set; }
        public ICollection<TblForecastUsersQtyWeek> TblForecastUsersQtyWeek { get; set; }
        public ICollection<TblForecastWpphases> TblForecastWpphases { get; set; }
        public ICollection<TblScopeWpphaseProgress> TblScopeWpphaseProgress { get; set; }
        public ICollection<TblWorkPreparationCode> TblWorkPreparationCode { get; set; }
    }
}

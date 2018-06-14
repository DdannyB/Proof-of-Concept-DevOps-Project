using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblTestSystem
    {
        public TblTestSystem()
        {
            TblBlindPoint = new HashSet<TblBlindPoint>();
            TblLisl = new HashSet<TblLisl>();
            TblPlantDataTestSystem = new HashSet<TblPlantDataTestSystem>();
            TblScopeTestSystem = new HashSet<TblScopeTestSystem>();
        }

        public long PkTestsystemid { get; set; }
        public long FkContractorid { get; set; }
        public long? FkTestsystemmediumid { get; set; }
        public string Testsystemnr { get; set; }
        public string Testsystemdescription { get; set; }
        public double? Pressure { get; set; }
        public decimal? Holdtime { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long? FkPressureunitofmeasurementid { get; set; }
        public long? FkHoldtimeunitofmeasurementid { get; set; }
        public bool Iscustom { get; set; }

        public TblContractor FkContractor { get; set; }
        public TblUnitOfMeasurement FkHoldtimeunitofmeasurement { get; set; }
        public TblUnitOfMeasurement FkPressureunitofmeasurement { get; set; }
        public TblTestSystemMedium FkTestsystemmedium { get; set; }
        public ICollection<TblBlindPoint> TblBlindPoint { get; set; }
        public ICollection<TblLisl> TblLisl { get; set; }
        public ICollection<TblPlantDataTestSystem> TblPlantDataTestSystem { get; set; }
        public ICollection<TblScopeTestSystem> TblScopeTestSystem { get; set; }
    }
}

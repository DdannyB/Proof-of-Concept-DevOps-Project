using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblPlantCustom
    {
        public TblPlantCustom()
        {
            TblJobDetailResourceSmartCalculationFkPlantcustom = new HashSet<TblJobDetailResourceSmartCalculation>();
            TblJobDetailResourceSmartCalculationFkPlantcustomdia = new HashSet<TblJobDetailResourceSmartCalculation>();
            TblJobDetailResourceSmartCalculationFkPlantcustomdn = new HashSet<TblJobDetailResourceSmartCalculation>();
            TblJobDetailResourceSmartCalculationFkPlantcustomlbs = new HashSet<TblJobDetailResourceSmartCalculation>();
            TblJobDetailResourceSmartCalculationFkPlantcustompn = new HashSet<TblJobDetailResourceSmartCalculation>();
            TblJobDetailResourceSmartCalculationFkPlantcustomquantity = new HashSet<TblJobDetailResourceSmartCalculation>();
            TblPlantCustomShortcode = new HashSet<TblPlantCustomShortcode>();
            TblPlantDataCustom = new HashSet<TblPlantDataCustom>();
            TblWallpaperStaticCol = new HashSet<TblWallpaperStaticCol>();
        }

        public long PkPlantcustomid { get; set; }
        public string Plantcustomdescription { get; set; }
        public bool Isxml { get; set; }
        public bool Iseditable { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public bool Isrosertechdata { get; set; }
        public long? FkUnitofmeasurementid { get; set; }
        public bool Isroserprocessdata { get; set; }
        public string Grouping { get; set; }
        public int? Relationtype { get; set; }
        public long? FkProductid { get; set; }
        public long? FkTestsystemmediumid { get; set; }

        public TblProduct FkProduct { get; set; }
        public TblTestSystemMedium FkTestsystemmedium { get; set; }
        public TblUnitOfMeasurement FkUnitofmeasurement { get; set; }
        public ICollection<TblJobDetailResourceSmartCalculation> TblJobDetailResourceSmartCalculationFkPlantcustom { get; set; }
        public ICollection<TblJobDetailResourceSmartCalculation> TblJobDetailResourceSmartCalculationFkPlantcustomdia { get; set; }
        public ICollection<TblJobDetailResourceSmartCalculation> TblJobDetailResourceSmartCalculationFkPlantcustomdn { get; set; }
        public ICollection<TblJobDetailResourceSmartCalculation> TblJobDetailResourceSmartCalculationFkPlantcustomlbs { get; set; }
        public ICollection<TblJobDetailResourceSmartCalculation> TblJobDetailResourceSmartCalculationFkPlantcustompn { get; set; }
        public ICollection<TblJobDetailResourceSmartCalculation> TblJobDetailResourceSmartCalculationFkPlantcustomquantity { get; set; }
        public ICollection<TblPlantCustomShortcode> TblPlantCustomShortcode { get; set; }
        public ICollection<TblPlantDataCustom> TblPlantDataCustom { get; set; }
        public ICollection<TblWallpaperStaticCol> TblWallpaperStaticCol { get; set; }
    }
}

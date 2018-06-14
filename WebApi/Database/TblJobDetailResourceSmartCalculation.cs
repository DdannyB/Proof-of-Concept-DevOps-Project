using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblJobDetailResourceSmartCalculation
    {
        public long PkJobdetailresourcesmartcalculationid { get; set; }
        public long FkJobdetailresourceid { get; set; }
        public long FkCalcgroupmainid { get; set; }
        public long FkCalcgroupsubid { get; set; }
        public long? FkPlantcustomid { get; set; }
        public long? FkPlantcustomdiaid { get; set; }
        public long? FkPlantcustomlbsid { get; set; }
        public long? FkPlantcustomdnid { get; set; }
        public long? FkPlantcustompnid { get; set; }
        public decimal? Jobdetailresourcesmartcalculationquantity { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long? FkPlantcustomquantityid { get; set; }

        public TblCalcGroupMain FkCalcgroupmain { get; set; }
        public TblCalcGroupSub FkCalcgroupsub { get; set; }
        public TblJobDetailResource FkJobdetailresource { get; set; }
        public TblPlantCustom FkPlantcustom { get; set; }
        public TblPlantCustom FkPlantcustomdia { get; set; }
        public TblPlantCustom FkPlantcustomdn { get; set; }
        public TblPlantCustom FkPlantcustomlbs { get; set; }
        public TblPlantCustom FkPlantcustompn { get; set; }
        public TblPlantCustom FkPlantcustomquantity { get; set; }
    }
}

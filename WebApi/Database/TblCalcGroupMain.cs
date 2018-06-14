using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblCalcGroupMain
    {
        public TblCalcGroupMain()
        {
            TblBlindTypeNormPosActivityNormbaseReference = new HashSet<TblBlindTypeNormPosActivityNormbaseReference>();
            TblCalcGroupCorfactor = new HashSet<TblCalcGroupCorfactor>();
            TblCalcGroupNormbaseMemo = new HashSet<TblCalcGroupNormbaseMemo>();
            TblJobDetailResourceSmartCalculation = new HashSet<TblJobDetailResourceSmartCalculation>();
            TblNormbase = new HashSet<TblNormbase>();
        }

        public long PkCalcgroupmainid { get; set; }
        public long FkNormsetid { get; set; }
        public string Calcgroupmaincode { get; set; }
        public string CalcgroupmaindescriptionL1 { get; set; }
        public string CalcgroupmaindescriptionL2 { get; set; }
        public string CalcgroupmaindescriptionL3 { get; set; }
        public string CalcgroupmaindescriptionL4 { get; set; }
        public string CalcgroupmaindescriptionL5 { get; set; }
        public string Normbasetype { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblNormset FkNormset { get; set; }
        public ICollection<TblBlindTypeNormPosActivityNormbaseReference> TblBlindTypeNormPosActivityNormbaseReference { get; set; }
        public ICollection<TblCalcGroupCorfactor> TblCalcGroupCorfactor { get; set; }
        public ICollection<TblCalcGroupNormbaseMemo> TblCalcGroupNormbaseMemo { get; set; }
        public ICollection<TblJobDetailResourceSmartCalculation> TblJobDetailResourceSmartCalculation { get; set; }
        public ICollection<TblNormbase> TblNormbase { get; set; }
    }
}

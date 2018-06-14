using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblCalcGroupSub
    {
        public TblCalcGroupSub()
        {
            TblBlindTypeNormPosActivityNormbaseReference = new HashSet<TblBlindTypeNormPosActivityNormbaseReference>();
            TblCalcGroupCorfactor = new HashSet<TblCalcGroupCorfactor>();
            TblCalcGroupNormbaseMemo = new HashSet<TblCalcGroupNormbaseMemo>();
            TblCalcGroupXrefFkCalcgroupsubid1Navigation = new HashSet<TblCalcGroupXref>();
            TblCalcGroupXrefFkCalcgroupsubid2Navigation = new HashSet<TblCalcGroupXref>();
            TblJobDetailResourceSmartCalculation = new HashSet<TblJobDetailResourceSmartCalculation>();
            TblNormbase = new HashSet<TblNormbase>();
        }

        public long PkCalcgroupsubid { get; set; }
        public long FkNormsetid { get; set; }
        public string Calcgroupsubnumber { get; set; }
        public string CalcgroupsubnameL1 { get; set; }
        public string CalcgroupsubnameL2 { get; set; }
        public string CalcgroupsubnameL3 { get; set; }
        public string CalcgroupsubnameL4 { get; set; }
        public string CalcgroupsubnameL5 { get; set; }
        public string CalcgroupsubmemoL1 { get; set; }
        public string CalcgroupsubmemoL2 { get; set; }
        public string CalcgroupsubmemoL3 { get; set; }
        public string CalcgroupsubmemoL4 { get; set; }
        public string CalcgroupsubmemoL5 { get; set; }
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
        public ICollection<TblCalcGroupXref> TblCalcGroupXrefFkCalcgroupsubid1Navigation { get; set; }
        public ICollection<TblCalcGroupXref> TblCalcGroupXrefFkCalcgroupsubid2Navigation { get; set; }
        public ICollection<TblJobDetailResourceSmartCalculation> TblJobDetailResourceSmartCalculation { get; set; }
        public ICollection<TblNormbase> TblNormbase { get; set; }
    }
}

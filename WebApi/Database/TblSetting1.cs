using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblSetting1
    {
        public long PkSettingid { get; set; }
        public long FkProjectid { get; set; }
        public int? Oldid { get; set; }
        public string Olddb { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public string Primaryreportfield { get; set; }
        public string Secondaryreportfield { get; set; }
        public int Renderpdfdpi { get; set; }
        public bool? Iserroremail { get; set; }
        public string Ho1caption { get; set; }
        public string Ho2caption { get; set; }
        public string P3actprefix { get; set; }
        public string P3mlstformat { get; set; }
        public int Pdfexpimgquality { get; set; }
        public bool Rrrequiredbeforefreeze { get; set; }
        public string Pdfexpfoldergrouping { get; set; }
        public bool? Qc04printpunch { get; set; }
        public bool? PdfexpallowA3 { get; set; }
        public bool? Wp01barcode { get; set; }
        public bool Pg01qualitycontrol { get; set; }
        public int Pg01offsetdate { get; set; }
        public string Pg01typedate { get; set; }
        public DateTime Pg10startdate { get; set; }
        public DateTime Pg10enddate { get; set; }
        public bool? Allowdoceditonfreeze { get; set; }
        public string Pg01groupcolumn1 { get; set; }
        public string Pg01groupcolumn2 { get; set; }
        public string Pg01groupcolumn3 { get; set; }
        public string Pg01groupcolumn4 { get; set; }
        public string Pdfexpfilepresuf { get; set; }
        public bool? Allowcustomjob { get; set; }
        public bool? Allowcustommaterial { get; set; }
        public bool? Allowwpholderplancardeditonfreeze { get; set; }
        public bool? Multiplyprocurementcorrectionfactors { get; set; }
        public bool Applyprocurementcorrectionfactorstoestimates { get; set; }
        public string Pg01maingroup { get; set; }
        public int? Pg01maingroupcolor { get; set; }
        public int Reportheaderfield { get; set; }
        public bool Pg01showfinishdate { get; set; }
        public DateTime? Lastimportdate { get; set; }
        public bool? Pl01showprogress { get; set; }
        public string Pl01customdate1 { get; set; }
        public string Pl01customdate2 { get; set; }
        public int Allowrebookprogress { get; set; }
        public int Resourceappearance { get; set; }
        public int Allowclearprogress { get; set; }
        public bool Syncscopeswithscheduleit { get; set; }
        public bool? Allowdoceditonscopefreeze { get; set; }
        public bool Wp01showjobduration { get; set; }
        public int Pg05grouping { get; set; }
        public int? Pg05sort { get; set; }
        public int Pg10settings { get; set; }
        public bool Correctnormbaseswithprice { get; set; }
        public bool Webtimeregistrationenabled { get; set; }

        public TblProject FkProject { get; set; }
    }
}

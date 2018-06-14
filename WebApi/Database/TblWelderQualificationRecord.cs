using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblWelderQualificationRecord
    {
        public long PkWelderqualificationrecordid { get; set; }
        public long FkWelderqualificationid { get; set; }
        public string Ndereportnumber { get; set; }
        public DateTime Expirationdate { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }
        public long? FkDiaid { get; set; }
        public long? FkDnid { get; set; }
        public long? FkThicknessid { get; set; }
        public string Remark { get; set; }
        public DateTime Issuedate { get; set; }
        public string Weldercertificatenumber { get; set; }

        public TblDia FkDia { get; set; }
        public TblDn FkDn { get; set; }
        public TblThickness FkThickness { get; set; }
        public TblWelderQualification FkWelderqualification { get; set; }
    }
}

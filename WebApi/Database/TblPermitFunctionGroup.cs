using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblPermitFunctionGroup
    {
        public TblPermitFunctionGroup()
        {
            TblBasePermitAuthorization = new HashSet<TblBasePermitAuthorization>();
            TblUserPermitFunctionGroup = new HashSet<TblUserPermitFunctionGroup>();
        }

        public long PkPermitfunctiongroupid { get; set; }
        public string Permitfunctiongroupcode { get; set; }
        public string Permitfunctiongroupdescription { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public ICollection<TblBasePermitAuthorization> TblBasePermitAuthorization { get; set; }
        public ICollection<TblUserPermitFunctionGroup> TblUserPermitFunctionGroup { get; set; }
    }
}

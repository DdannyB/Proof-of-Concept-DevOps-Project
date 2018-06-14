using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblUserProjectOrganisationStructure
    {
        public long PkUserprojectorganisationstructureid { get; set; }
        public long FkUserid { get; set; }
        public long FkProjectid { get; set; }
        public long FkOrganisationstructureid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblOrganisationStructure FkOrganisationstructure { get; set; }
        public TblProject FkProject { get; set; }
        public TblUser FkUser { get; set; }
    }
}

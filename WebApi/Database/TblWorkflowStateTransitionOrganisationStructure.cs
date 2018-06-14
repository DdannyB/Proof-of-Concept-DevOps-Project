using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblWorkflowStateTransitionOrganisationStructure
    {
        public long PkWorkflowstatetransitionOrganisationStructureid { get; set; }
        public long FkWorkflowstatetransitionid { get; set; }
        public long FkOrganisationstructureid { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblOrganisationStructure FkOrganisationstructure { get; set; }
        public TblWorkflowStateTransition FkWorkflowstatetransition { get; set; }
    }
}

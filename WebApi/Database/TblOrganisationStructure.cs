using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblOrganisationStructure
    {
        public TblOrganisationStructure()
        {
            InverseFkParentorganisationstructure = new HashSet<TblOrganisationStructure>();
            TblUserProjectOrganisationStructure = new HashSet<TblUserProjectOrganisationStructure>();
            TblWorkflowStateTransitionOrganisationStructure = new HashSet<TblWorkflowStateTransitionOrganisationStructure>();
        }

        public long PkOrganisationstructureid { get; set; }
        public long FkOrganisationid { get; set; }
        public long? FkParentorganisationstructureid { get; set; }
        public string Organisationstructurename { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblOrganisation FkOrganisation { get; set; }
        public TblOrganisationStructure FkParentorganisationstructure { get; set; }
        public ICollection<TblOrganisationStructure> InverseFkParentorganisationstructure { get; set; }
        public ICollection<TblUserProjectOrganisationStructure> TblUserProjectOrganisationStructure { get; set; }
        public ICollection<TblWorkflowStateTransitionOrganisationStructure> TblWorkflowStateTransitionOrganisationStructure { get; set; }
    }
}

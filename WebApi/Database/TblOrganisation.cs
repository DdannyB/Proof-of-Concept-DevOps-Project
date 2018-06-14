using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblOrganisation
    {
        public TblOrganisation()
        {
            TblOrganisationStructure = new HashSet<TblOrganisationStructure>();
            TblProjectOrganisation = new HashSet<TblProjectOrganisation>();
        }

        public long PkOrganisationid { get; set; }
        public string Organisationname { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public ICollection<TblOrganisationStructure> TblOrganisationStructure { get; set; }
        public ICollection<TblProjectOrganisation> TblProjectOrganisation { get; set; }
    }
}

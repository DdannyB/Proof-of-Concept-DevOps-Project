using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblSubSbs
    {
        public TblSubSbs()
        {
            TblMilestone = new HashSet<TblMilestone>();
            TblPermitDataFkSbsid1Navigation = new HashSet<TblPermitData>();
            TblPermitDataFkSbsid2Navigation = new HashSet<TblPermitData>();
            TblPermitDataFkSbsid3Navigation = new HashSet<TblPermitData>();
            TblPlantDataFkSubsbsid1Navigation = new HashSet<TblPlantData>();
            TblPlantDataFkSubsbsid2Navigation = new HashSet<TblPlantData>();
            TblPlantDataFkSubsbsid3Navigation = new HashSet<TblPlantData>();
            TblScopeFkSubsbsid1Navigation = new HashSet<TblScope>();
            TblScopeFkSubsbsid2Navigation = new HashSet<TblScope>();
            TblScopeFkSubsbsid3Navigation = new HashSet<TblScope>();
            TblTemplateBlindPointFkSubsbsid1Navigation = new HashSet<TblTemplateBlindPoint>();
            TblTemplateBlindPointFkSubsbsid2Navigation = new HashSet<TblTemplateBlindPoint>();
            TblTemplateBlindPointFkSubsbsid3Navigation = new HashSet<TblTemplateBlindPoint>();
        }

        public long PkSubsbsid { get; set; }
        public long FkMainsbsid { get; set; }
        public string Subsbscode { get; set; }
        public string Subsbsdescription { get; set; }
        public string Exportcode { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public TblMainSbs FkMainsbs { get; set; }
        public ICollection<TblMilestone> TblMilestone { get; set; }
        public ICollection<TblPermitData> TblPermitDataFkSbsid1Navigation { get; set; }
        public ICollection<TblPermitData> TblPermitDataFkSbsid2Navigation { get; set; }
        public ICollection<TblPermitData> TblPermitDataFkSbsid3Navigation { get; set; }
        public ICollection<TblPlantData> TblPlantDataFkSubsbsid1Navigation { get; set; }
        public ICollection<TblPlantData> TblPlantDataFkSubsbsid2Navigation { get; set; }
        public ICollection<TblPlantData> TblPlantDataFkSubsbsid3Navigation { get; set; }
        public ICollection<TblScope> TblScopeFkSubsbsid1Navigation { get; set; }
        public ICollection<TblScope> TblScopeFkSubsbsid2Navigation { get; set; }
        public ICollection<TblScope> TblScopeFkSubsbsid3Navigation { get; set; }
        public ICollection<TblTemplateBlindPoint> TblTemplateBlindPointFkSubsbsid1Navigation { get; set; }
        public ICollection<TblTemplateBlindPoint> TblTemplateBlindPointFkSubsbsid2Navigation { get; set; }
        public ICollection<TblTemplateBlindPoint> TblTemplateBlindPointFkSubsbsid3Navigation { get; set; }
    }
}

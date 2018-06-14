using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblTemplateBlindPointDiscipline
    {
        public TblTemplateBlindPointDiscipline()
        {
            TblBlindPointDisciplineConfirmation = new HashSet<TblBlindPointDisciplineConfirmation>();
        }

        public long PkTemplateblindpointdisciplineid { get; set; }
        public long FkTemplateblindpointid { get; set; }
        public long? FkDisciplinetypeid { get; set; }
        public long? FkDisciplinecodeid { get; set; }
        public long? FkContractorid { get; set; }
        public int? Qty { get; set; }
        public decimal? Length { get; set; }
        public decimal? Width { get; set; }
        public decimal? Height { get; set; }
        public decimal? M3 { get; set; }
        public string Flangeinstructionno { get; set; }
        public decimal? M2 { get; set; }
        public DateTime? Confirmationdate { get; set; }
        public decimal? Hours { get; set; }
        public decimal? Price { get; set; }
        public string Memo { get; set; }
        public string Createuser { get; set; }
        public string Createcomputer { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifyuser { get; set; }
        public string Modifycomputer { get; set; }
        public DateTime Modifydate { get; set; }
        public long? FkUnitofmeasurementid { get; set; }
        public long FkSubdisciplineid { get; set; }
        public long? FkDiaid { get; set; }
        public long? FkBoltdiameterdiaid { get; set; }
        public long? FkBoltdiameterdnid { get; set; }
        public string Confirmationuser { get; set; }
        public long? FkThicknessid { get; set; }
        public long? FkDnid { get; set; }

        public TblDia FkBoltdiameterdia { get; set; }
        public TblDn FkBoltdiameterdn { get; set; }
        public TblContractor FkContractor { get; set; }
        public TblDia FkDia { get; set; }
        public TblDisciplineCode FkDisciplinecode { get; set; }
        public TblDisciplineType FkDisciplinetype { get; set; }
        public TblDn FkDn { get; set; }
        public TblSubDiscipline FkSubdiscipline { get; set; }
        public TblTemplateBlindPoint FkTemplateblindpoint { get; set; }
        public TblThickness FkThickness { get; set; }
        public TblUnitOfMeasurement FkUnitofmeasurement { get; set; }
        public ICollection<TblBlindPointDisciplineConfirmation> TblBlindPointDisciplineConfirmation { get; set; }
    }
}

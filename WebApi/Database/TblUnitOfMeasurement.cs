using System;
using System.Collections.Generic;

namespace WebApi.Database
{
    public partial class TblUnitOfMeasurement
    {
        public TblUnitOfMeasurement()
        {
            TblBoltingFkBoltareaUnitofmeasurement = new HashSet<TblBolting>();
            TblBoltingFkBoltelongationUnitofmeasurement = new HashSet<TblBolting>();
            TblBoltingFkBoltlgripUnitofmeasurement = new HashSet<TblBolting>();
            TblBoltingFkBoltlimitsUnitofmeasurement = new HashSet<TblBolting>();
            TblBoltingFkBoltstressUnitofmeasurement = new HashSet<TblBolting>();
            TblBoltingFkBolttensioncheckUnitofmeasurement = new HashSet<TblBolting>();
            TblBoltingFkBolttensiontightenUnitofmeasurement = new HashSet<TblBolting>();
            TblBoltingFkBolttorqmaxvalueUnitofmeasurement = new HashSet<TblBolting>();
            TblBoltingFkBolttorqvalueUnitofmeasurement = new HashSet<TblBolting>();
            TblBoltingFkBreaklooseUnitofmeasurement = new HashSet<TblBolting>();
            TblBoltingFkCompressionidUnitofmeasurement = new HashSet<TblBolting>();
            TblBoltingFkFinalreqboltstressUnitofmeasurement = new HashSet<TblBolting>();
            TblBoltingFkFinalreqstressUnitofmeasurement = new HashSet<TblBolting>();
            TblBoltingFkGriplengthUnitofmeasurement = new HashSet<TblBolting>();
            TblBoltingFkJackpressureUnitofmeasurement = new HashSet<TblBolting>();
            TblBoltingFkMaxtensioningpressUnitofmeasurement = new HashSet<TblBolting>();
            TblBoltingFkPass1Unitofmeasurement = new HashSet<TblBolting>();
            TblBoltingFkPass2Unitofmeasurement = new HashSet<TblBolting>();
            TblBoltingFkPass3Unitofmeasurement = new HashSet<TblBolting>();
            TblBoltingFkPass4Unitofmeasurement = new HashSet<TblBolting>();
            TblBoltingFkPass5Unitofmeasurement = new HashSet<TblBolting>();
            TblBoltingFkPumpsettingUnitofmeasurement = new HashSet<TblBolting>();
            TblBoltingFkRelaxationfactorUnitofmeasurement = new HashSet<TblBolting>();
            TblBoltingFkReqboltloadUnitofmeasurement = new HashSet<TblBolting>();
            TblBoltingFkResidualboltstressUnitofmeasurement = new HashSet<TblBolting>();
            TblBoltingFkResidualbolttensionUnitofmeasurement = new HashSet<TblBolting>();
            TblBoltingFkSwUnitofmeasurement = new HashSet<TblBolting>();
            TblBoltingFkTensioningvalueAUnitofmeasurement = new HashSet<TblBolting>();
            TblBoltingFkTensioningvalueBUnitofmeasurement = new HashSet<TblBolting>();
            TblBoltingFkToolareaUnitofmeasurement = new HashSet<TblBolting>();
            TblBoltingFkWashersthkUnitofmeasurement = new HashSet<TblBolting>();
            TblBoltingFkYieldpointUnitofmeasurement = new HashSet<TblBolting>();
            TblCertificate = new HashSet<TblCertificate>();
            TblJobDetailData = new HashSet<TblJobDetailData>();
            TblLibraryProcurementContractPricelist = new HashSet<TblLibraryProcurementContractPricelist>();
            TblLislNdeInspectionPlan = new HashSet<TblLislNdeInspectionPlan>();
            TblMaterialLibrary = new HashSet<TblMaterialLibrary>();
            TblNdeRequest = new HashSet<TblNdeRequest>();
            TblNormbase = new HashSet<TblNormbase>();
            TblPermitData = new HashSet<TblPermitData>();
            TblPlantCustom = new HashSet<TblPlantCustom>();
            TblPlantData = new HashSet<TblPlantData>();
            TblScope = new HashSet<TblScope>();
            TblTemplateBlindPointDiscipline = new HashSet<TblTemplateBlindPointDiscipline>();
            TblTemplateBlindPointFkBoltareaUnitofmeasurement = new HashSet<TblTemplateBlindPoint>();
            TblTemplateBlindPointFkBoltelongationUnitofmeasurement = new HashSet<TblTemplateBlindPoint>();
            TblTemplateBlindPointFkBoltlgripUnitofmeasurement = new HashSet<TblTemplateBlindPoint>();
            TblTemplateBlindPointFkBoltlimitsUnitofmeasurement = new HashSet<TblTemplateBlindPoint>();
            TblTemplateBlindPointFkBoltstressUnitofmeasurement = new HashSet<TblTemplateBlindPoint>();
            TblTemplateBlindPointFkBolttensioncheckUnitofmeasurement = new HashSet<TblTemplateBlindPoint>();
            TblTemplateBlindPointFkBolttensiontightenUnitofmeasurement = new HashSet<TblTemplateBlindPoint>();
            TblTemplateBlindPointFkBolttorqmaxvalueUnitofmeasurement = new HashSet<TblTemplateBlindPoint>();
            TblTemplateBlindPointFkBolttorqvalueUnitofmeasurement = new HashSet<TblTemplateBlindPoint>();
            TblTemplateBlindPointFkBreaklooseUnitofmeasurement = new HashSet<TblTemplateBlindPoint>();
            TblTemplateBlindPointFkCompressionidUnitofmeasurement = new HashSet<TblTemplateBlindPoint>();
            TblTemplateBlindPointFkFinalreqboltstressUnitofmeasurement = new HashSet<TblTemplateBlindPoint>();
            TblTemplateBlindPointFkFinalreqstressUnitofmeasurement = new HashSet<TblTemplateBlindPoint>();
            TblTemplateBlindPointFkGriplengthUnitofmeasurement = new HashSet<TblTemplateBlindPoint>();
            TblTemplateBlindPointFkJackpressureUnitofmeasurement = new HashSet<TblTemplateBlindPoint>();
            TblTemplateBlindPointFkMaxtensioningpressUnitofmeasurement = new HashSet<TblTemplateBlindPoint>();
            TblTemplateBlindPointFkPass1Unitofmeasurement = new HashSet<TblTemplateBlindPoint>();
            TblTemplateBlindPointFkPass2Unitofmeasurement = new HashSet<TblTemplateBlindPoint>();
            TblTemplateBlindPointFkPass3Unitofmeasurement = new HashSet<TblTemplateBlindPoint>();
            TblTemplateBlindPointFkPass4Unitofmeasurement = new HashSet<TblTemplateBlindPoint>();
            TblTemplateBlindPointFkPass5Unitofmeasurement = new HashSet<TblTemplateBlindPoint>();
            TblTemplateBlindPointFkPumpsettingUnitofmeasurement = new HashSet<TblTemplateBlindPoint>();
            TblTemplateBlindPointFkRelaxationfactorUnitofmeasurement = new HashSet<TblTemplateBlindPoint>();
            TblTemplateBlindPointFkReqboltloadUnitofmeasurement = new HashSet<TblTemplateBlindPoint>();
            TblTemplateBlindPointFkResidualboltstressUnitofmeasurement = new HashSet<TblTemplateBlindPoint>();
            TblTemplateBlindPointFkResidualbolttensionUnitofmeasurement = new HashSet<TblTemplateBlindPoint>();
            TblTemplateBlindPointFkSwUnitofmeasurement = new HashSet<TblTemplateBlindPoint>();
            TblTemplateBlindPointFkTensioningvalueAUnitofmeasurement = new HashSet<TblTemplateBlindPoint>();
            TblTemplateBlindPointFkTensioningvalueBUnitofmeasurement = new HashSet<TblTemplateBlindPoint>();
            TblTemplateBlindPointFkToolareaUnitofmeasurement = new HashSet<TblTemplateBlindPoint>();
            TblTemplateBlindPointFkWashersthkUnitofmeasurement = new HashSet<TblTemplateBlindPoint>();
            TblTemplateBlindPointFkYieldpointUnitofmeasurement = new HashSet<TblTemplateBlindPoint>();
            TblTestSystemFkHoldtimeunitofmeasurement = new HashSet<TblTestSystem>();
            TblTestSystemFkPressureunitofmeasurement = new HashSet<TblTestSystem>();
            TblToolsAndConsumables = new HashSet<TblToolsAndConsumables>();
        }

        public long PkUnitofmeasurementid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Createcomputer { get; set; }
        public string Createuser { get; set; }
        public DateTime Createdate { get; set; }
        public string Modifycomputer { get; set; }
        public string Modifyuser { get; set; }
        public DateTime Modifydate { get; set; }

        public ICollection<TblBolting> TblBoltingFkBoltareaUnitofmeasurement { get; set; }
        public ICollection<TblBolting> TblBoltingFkBoltelongationUnitofmeasurement { get; set; }
        public ICollection<TblBolting> TblBoltingFkBoltlgripUnitofmeasurement { get; set; }
        public ICollection<TblBolting> TblBoltingFkBoltlimitsUnitofmeasurement { get; set; }
        public ICollection<TblBolting> TblBoltingFkBoltstressUnitofmeasurement { get; set; }
        public ICollection<TblBolting> TblBoltingFkBolttensioncheckUnitofmeasurement { get; set; }
        public ICollection<TblBolting> TblBoltingFkBolttensiontightenUnitofmeasurement { get; set; }
        public ICollection<TblBolting> TblBoltingFkBolttorqmaxvalueUnitofmeasurement { get; set; }
        public ICollection<TblBolting> TblBoltingFkBolttorqvalueUnitofmeasurement { get; set; }
        public ICollection<TblBolting> TblBoltingFkBreaklooseUnitofmeasurement { get; set; }
        public ICollection<TblBolting> TblBoltingFkCompressionidUnitofmeasurement { get; set; }
        public ICollection<TblBolting> TblBoltingFkFinalreqboltstressUnitofmeasurement { get; set; }
        public ICollection<TblBolting> TblBoltingFkFinalreqstressUnitofmeasurement { get; set; }
        public ICollection<TblBolting> TblBoltingFkGriplengthUnitofmeasurement { get; set; }
        public ICollection<TblBolting> TblBoltingFkJackpressureUnitofmeasurement { get; set; }
        public ICollection<TblBolting> TblBoltingFkMaxtensioningpressUnitofmeasurement { get; set; }
        public ICollection<TblBolting> TblBoltingFkPass1Unitofmeasurement { get; set; }
        public ICollection<TblBolting> TblBoltingFkPass2Unitofmeasurement { get; set; }
        public ICollection<TblBolting> TblBoltingFkPass3Unitofmeasurement { get; set; }
        public ICollection<TblBolting> TblBoltingFkPass4Unitofmeasurement { get; set; }
        public ICollection<TblBolting> TblBoltingFkPass5Unitofmeasurement { get; set; }
        public ICollection<TblBolting> TblBoltingFkPumpsettingUnitofmeasurement { get; set; }
        public ICollection<TblBolting> TblBoltingFkRelaxationfactorUnitofmeasurement { get; set; }
        public ICollection<TblBolting> TblBoltingFkReqboltloadUnitofmeasurement { get; set; }
        public ICollection<TblBolting> TblBoltingFkResidualboltstressUnitofmeasurement { get; set; }
        public ICollection<TblBolting> TblBoltingFkResidualbolttensionUnitofmeasurement { get; set; }
        public ICollection<TblBolting> TblBoltingFkSwUnitofmeasurement { get; set; }
        public ICollection<TblBolting> TblBoltingFkTensioningvalueAUnitofmeasurement { get; set; }
        public ICollection<TblBolting> TblBoltingFkTensioningvalueBUnitofmeasurement { get; set; }
        public ICollection<TblBolting> TblBoltingFkToolareaUnitofmeasurement { get; set; }
        public ICollection<TblBolting> TblBoltingFkWashersthkUnitofmeasurement { get; set; }
        public ICollection<TblBolting> TblBoltingFkYieldpointUnitofmeasurement { get; set; }
        public ICollection<TblCertificate> TblCertificate { get; set; }
        public ICollection<TblJobDetailData> TblJobDetailData { get; set; }
        public ICollection<TblLibraryProcurementContractPricelist> TblLibraryProcurementContractPricelist { get; set; }
        public ICollection<TblLislNdeInspectionPlan> TblLislNdeInspectionPlan { get; set; }
        public ICollection<TblMaterialLibrary> TblMaterialLibrary { get; set; }
        public ICollection<TblNdeRequest> TblNdeRequest { get; set; }
        public ICollection<TblNormbase> TblNormbase { get; set; }
        public ICollection<TblPermitData> TblPermitData { get; set; }
        public ICollection<TblPlantCustom> TblPlantCustom { get; set; }
        public ICollection<TblPlantData> TblPlantData { get; set; }
        public ICollection<TblScope> TblScope { get; set; }
        public ICollection<TblTemplateBlindPointDiscipline> TblTemplateBlindPointDiscipline { get; set; }
        public ICollection<TblTemplateBlindPoint> TblTemplateBlindPointFkBoltareaUnitofmeasurement { get; set; }
        public ICollection<TblTemplateBlindPoint> TblTemplateBlindPointFkBoltelongationUnitofmeasurement { get; set; }
        public ICollection<TblTemplateBlindPoint> TblTemplateBlindPointFkBoltlgripUnitofmeasurement { get; set; }
        public ICollection<TblTemplateBlindPoint> TblTemplateBlindPointFkBoltlimitsUnitofmeasurement { get; set; }
        public ICollection<TblTemplateBlindPoint> TblTemplateBlindPointFkBoltstressUnitofmeasurement { get; set; }
        public ICollection<TblTemplateBlindPoint> TblTemplateBlindPointFkBolttensioncheckUnitofmeasurement { get; set; }
        public ICollection<TblTemplateBlindPoint> TblTemplateBlindPointFkBolttensiontightenUnitofmeasurement { get; set; }
        public ICollection<TblTemplateBlindPoint> TblTemplateBlindPointFkBolttorqmaxvalueUnitofmeasurement { get; set; }
        public ICollection<TblTemplateBlindPoint> TblTemplateBlindPointFkBolttorqvalueUnitofmeasurement { get; set; }
        public ICollection<TblTemplateBlindPoint> TblTemplateBlindPointFkBreaklooseUnitofmeasurement { get; set; }
        public ICollection<TblTemplateBlindPoint> TblTemplateBlindPointFkCompressionidUnitofmeasurement { get; set; }
        public ICollection<TblTemplateBlindPoint> TblTemplateBlindPointFkFinalreqboltstressUnitofmeasurement { get; set; }
        public ICollection<TblTemplateBlindPoint> TblTemplateBlindPointFkFinalreqstressUnitofmeasurement { get; set; }
        public ICollection<TblTemplateBlindPoint> TblTemplateBlindPointFkGriplengthUnitofmeasurement { get; set; }
        public ICollection<TblTemplateBlindPoint> TblTemplateBlindPointFkJackpressureUnitofmeasurement { get; set; }
        public ICollection<TblTemplateBlindPoint> TblTemplateBlindPointFkMaxtensioningpressUnitofmeasurement { get; set; }
        public ICollection<TblTemplateBlindPoint> TblTemplateBlindPointFkPass1Unitofmeasurement { get; set; }
        public ICollection<TblTemplateBlindPoint> TblTemplateBlindPointFkPass2Unitofmeasurement { get; set; }
        public ICollection<TblTemplateBlindPoint> TblTemplateBlindPointFkPass3Unitofmeasurement { get; set; }
        public ICollection<TblTemplateBlindPoint> TblTemplateBlindPointFkPass4Unitofmeasurement { get; set; }
        public ICollection<TblTemplateBlindPoint> TblTemplateBlindPointFkPass5Unitofmeasurement { get; set; }
        public ICollection<TblTemplateBlindPoint> TblTemplateBlindPointFkPumpsettingUnitofmeasurement { get; set; }
        public ICollection<TblTemplateBlindPoint> TblTemplateBlindPointFkRelaxationfactorUnitofmeasurement { get; set; }
        public ICollection<TblTemplateBlindPoint> TblTemplateBlindPointFkReqboltloadUnitofmeasurement { get; set; }
        public ICollection<TblTemplateBlindPoint> TblTemplateBlindPointFkResidualboltstressUnitofmeasurement { get; set; }
        public ICollection<TblTemplateBlindPoint> TblTemplateBlindPointFkResidualbolttensionUnitofmeasurement { get; set; }
        public ICollection<TblTemplateBlindPoint> TblTemplateBlindPointFkSwUnitofmeasurement { get; set; }
        public ICollection<TblTemplateBlindPoint> TblTemplateBlindPointFkTensioningvalueAUnitofmeasurement { get; set; }
        public ICollection<TblTemplateBlindPoint> TblTemplateBlindPointFkTensioningvalueBUnitofmeasurement { get; set; }
        public ICollection<TblTemplateBlindPoint> TblTemplateBlindPointFkToolareaUnitofmeasurement { get; set; }
        public ICollection<TblTemplateBlindPoint> TblTemplateBlindPointFkWashersthkUnitofmeasurement { get; set; }
        public ICollection<TblTemplateBlindPoint> TblTemplateBlindPointFkYieldpointUnitofmeasurement { get; set; }
        public ICollection<TblTestSystem> TblTestSystemFkHoldtimeunitofmeasurement { get; set; }
        public ICollection<TblTestSystem> TblTestSystemFkPressureunitofmeasurement { get; set; }
        public ICollection<TblToolsAndConsumables> TblToolsAndConsumables { get; set; }
    }
}

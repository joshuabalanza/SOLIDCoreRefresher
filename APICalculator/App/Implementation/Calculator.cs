using APICalculator.App.Interfaces;
using APICalculator.DTOs;
using APICalculator.Process.Interfaces;

namespace APICalculator.App.Implementation
{
    public class BasicCalculator : IBasicCalculatorServices
    {
        private readonly IBasicCalculationProcess _basicCalculationProcess;
        public BasicCalculator(IBasicCalculationProcess basicCalculationProcess)
        {
            _basicCalculationProcess = basicCalculationProcess;
        }

        public decimal BasicCalculation(SampleocpDTOs sampleocpDTOs)
        {
            return _basicCalculationProcess.BasicCalculation(sampleocpDTOs);
        }
    }


    public class ScientificCalculator : IScientificCalculatorServices
    {
        private readonly IScientificCalculationProcess _scientificCalculationProcess;
        public ScientificCalculator(IScientificCalculationProcess scientificCalculationProcess)
        {
            _scientificCalculationProcess = scientificCalculationProcess;
        }

        public decimal ScientificCalculation(SampleocpDTOs sampleocpDTOs)
        {
            return _scientificCalculationProcess.ScientificCalculation(sampleocpDTOs);
        }
    }
}
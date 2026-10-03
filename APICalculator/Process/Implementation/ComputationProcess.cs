using APICalculator.DTOs;
using APICalculator.Process.Interfaces;

namespace APICalculator.Process.Implementation
{
    public class BasicCalculationProcess : IBasicCalculationProcess
    {
        public decimal BasicCalculation(SampleocpDTOs sampleocpDTOs)
        {
            switch (sampleocpDTOs.operationType)
            {
                case "Add":
                    // Example basic calculation: addition
                    return sampleocpDTOs.sampleValue1 + sampleocpDTOs.sampleValue2;
                case "Subtract":
                    // Example basic calculation: subtraction
                    return sampleocpDTOs.sampleValue1 - sampleocpDTOs.sampleValue2;
                case "Multiply":
                    // Example basic calculation: multiplication
                    return sampleocpDTOs.sampleValue1 * sampleocpDTOs.sampleValue2;
                case "Divide":
                    // Example basic calculation: division
                    return sampleocpDTOs.sampleValue1 / sampleocpDTOs.sampleValue2;
                default:
                    throw new Exception($"Invalid operation type: {sampleocpDTOs.operationType}");
            }
        }
    }
    public class ScientificCalculationProcess : IScientificCalculationProcess
    {
        private readonly IBasicCalculationProcess _basicCalculationProcess;

        public ScientificCalculationProcess(IBasicCalculationProcess basicCalculationProcess)
        {
            _basicCalculationProcess = basicCalculationProcess;
        }
        public decimal ScientificCalculation(SampleocpDTOs sampleocpDTOs)
        {
            switch (sampleocpDTOs.operationType)
            {
                case "Power":
                    var sampleValue1 = sampleocpDTOs.sampleValue1;
                    var sampleValue2 = sampleocpDTOs.sampleValue2;
                    // Example scientific calculation: power
                    return (decimal)Math.Pow((double)sampleValue1, (double)sampleValue2);
                case "SquareRoot":
                    var value = sampleocpDTOs.sampleValue1;
                    // Example scientific calculation: square root
                    return (decimal)Math.Sqrt((double)value);
                case "Logarithm":
                    var logValue = sampleocpDTOs.sampleValue1;
                    // Example scientific calculation: logarithm
                    return (decimal)Math.Log((double)logValue);
                default:
                    return _basicCalculationProcess.BasicCalculation(sampleocpDTOs);
            }
        }
    }
}
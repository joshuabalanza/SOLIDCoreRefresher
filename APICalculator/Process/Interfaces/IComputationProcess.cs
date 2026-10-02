using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APICalculator.DTOs;

namespace APICalculator.Process.Interfaces
{
    public interface IBasicCalculationProcess
    {
        decimal BasicCalculation(SampleocpDTOs sampleocpDTOs);
    }
    public interface IScientificCalculationProcess
    {
        decimal ScientificCalculation(SampleocpDTOs sampleocpDTOs);
    }
}
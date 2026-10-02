using System;
using APICalculator.DTOs;

namespace APICalculator.App.Interfaces
{
    public interface IBasicCalculatorServices
    {
        decimal BasicCalculation(SampleocpDTOs sampleocpDTOs);
    }

    public interface IScientificCalculatorServices
    {
        decimal ScientificCalculation(SampleocpDTOs sampleocpDTOs);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APICalculator.DTOs;

namespace APICalculator.Services.Interfaces
{
    public interface ICalculatorServices
    {
        string CalculatorType { get; }
        decimal Calculate(SampleocpDTOs sampleValue);
    }
}
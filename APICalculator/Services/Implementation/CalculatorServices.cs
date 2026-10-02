using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APICalculator.App.Interfaces;
using APICalculator.Services.Interfaces;
using APICalculator.DTOs;

namespace APICalculator.Services.Implementation
{
    public class BasicCalculatorServices : ICalculatorServices
    {

        private readonly IBasicCalculatorServices _basicCalculatorServices;

        public BasicCalculatorServices(IBasicCalculatorServices basicCalculatorServices)
        {
            _basicCalculatorServices = basicCalculatorServices;
        }


        public string CalculatorType => "BasicCalculator";
        public decimal Calculate(SampleocpDTOs sampleValue)
        {
            return _basicCalculatorServices.BasicCalculation(sampleValue);
        }
    }
    public class ScientificCalculatorServices : ICalculatorServices
    {

        private readonly IScientificCalculatorServices _scientificCalculatorServices;

        public ScientificCalculatorServices(IScientificCalculatorServices scientificCalculatorServices)
        {
            _scientificCalculatorServices = scientificCalculatorServices;
        }

        public string CalculatorType => "ScientificCalculator";
        public decimal Calculate(SampleocpDTOs sampleValue)
        {
            return _scientificCalculatorServices.ScientificCalculation(sampleValue);
        }
    }
}
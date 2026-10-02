using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APICalculator.Services.Interfaces;
namespace APICalculator.Process.Interfaces
{
    public interface ICalculatorProcess
    {
        ICalculatorServices LaunchCalculator(string calculatorType);
    }
}
using APICalculator.Services.Interfaces;
using APICalculator.Process.Interfaces;

namespace APICalculator.Process.Implementation
{
    public class CalculatorProcess : ICalculatorProcess
    {
        private Dictionary<string, ICalculatorServices> _calculatorServices;

        public CalculatorProcess(IEnumerable<ICalculatorServices> calculatorServices)
        {
            _calculatorServices = calculatorServices.ToDictionary(s => s.CalculatorType, s => s);
        }

        public ICalculatorServices LaunchCalculator(string calculatorType)
        {
            return _calculatorServices.TryGetValue(calculatorType, out var service) ? service :
                throw new ArgumentException($"No service found for calculator type {calculatorType}");
        }
    }
}
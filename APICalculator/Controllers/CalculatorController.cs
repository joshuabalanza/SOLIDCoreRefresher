using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using APICalculator.DTOs;
using APICalculator.Process.Interfaces;
using Mapster;

namespace APICalculator.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ICalculatorProcess _calculatorProcess;


        public CalculatorController(ICalculatorProcess calculatorProcess)
        {
            _calculatorProcess = calculatorProcess;
        }

        [HttpPost("{calculatorType}")]
        public ActionResult<SampleocpResult> Calculator([FromBody] SampleocpDTOs sampleValue, string calculatorType)
        {
            try
            {
                var calculate = _calculatorProcess.LaunchCalculator(calculatorType);
                SampleocpResult total = new SampleocpResult(calculate.Calculate(sampleValue));
                return Ok(total.Adapt<SampleocpDTOs>());
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
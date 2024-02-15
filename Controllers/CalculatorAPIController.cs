using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Calculator_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorAPIController : ControllerBase
    {
        private readonly CalculatorLibrary calculator;

        public CalculatorAPIController()
        {
            calculator = new CalculatorLibrary();
        }

        [HttpGet("Add")]
        public IActionResult Add(decimal num1, decimal num2)
        {
            return Ok(calculator.Add(num1, num2));
        }

        [HttpGet("Subtract")]
        public IActionResult Subtract(decimal num1, decimal num2)
        {
            return Ok(calculator.Subtract(num1, num2));

        }

        [HttpGet("Multiply")]
        public IActionResult Multiply(decimal num1, decimal num2)
        {
            return Ok(calculator.Multiply(num1, num2));

        }

        [HttpGet("Divide")]
        public ActionResult Divide(decimal num1, decimal num2)
        {
            return Ok(calculator.Divide(num1, num2));

        }

        [HttpGet("Modulo")]
        public ActionResult Modulo(decimal num1, decimal num2)
        {
            return Ok(calculator.Modulo(num1, num2));

        }
    }

}

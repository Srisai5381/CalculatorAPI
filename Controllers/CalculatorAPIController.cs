using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Calculator_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorAPIController : ControllerBase
    {
        [HttpGet("Add")]
        public IActionResult Add(decimal num1, decimal num2)
        {
            return Ok(num1 + num2);
        }

        [HttpGet("Subtract")]
        public IActionResult Subtract(decimal num1, decimal num2)
        {
            return Ok(num1 - num2);
        }

        [HttpGet("Multiply")]
        public IActionResult Multiply(decimal num1, decimal num2)
        {
            return Ok(num1 * num2);
        }

        [HttpGet("Divide")]
        public ActionResult Divide(decimal num1, decimal num2)
        {
            if (num2 == 0)
            {
                return BadRequest("Input cannot be zero");
            }
            else
            {
                return Ok(num1 / num2);
            }
        }

        [HttpGet("Modulo")]
        public ActionResult Modulo(decimal num1, decimal num2)
        {
            if (num1 == 0)
            {
                return BadRequest("Divisor cannot be zero");
            }

            decimal result = num1 % num2;
            return Ok(result);
        }
    }

}

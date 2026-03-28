using Microsoft.AspNetCore.Mvc;
using RestWithASPNET10.Service;
using static RestWithASPNET10.Utils.StringToDecimalConverter;

namespace RestWithASPNET10.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MathController : ControllerBase
    {


        [HttpGet("soma/{firstNumber}/{secondNumber}")]
        public IActionResult Soma(string firstNumber, string secondNumber)
        {     
            if (!TryConvertToDecimal(firstNumber, out var num1) ||
            !TryConvertToDecimal(secondNumber, out var num2))
            {
                return BadRequest("Invalid Input!");
            }

            decimal? result = MathService.Soma(num1, num2);

            if (result == null)
            {
                return BadRequest("Invalid Input!");
            }

            return Ok(result);
        }

        [HttpGet("subtracao/{firstNumber}/{secondNumber}")]
        public IActionResult Subtracao(string firstNumber, string secondNumber)
        {
            if (!TryConvertToDecimal(firstNumber, out var num1) ||
            !TryConvertToDecimal(secondNumber, out var num2))
            {
                return BadRequest("Invalid Input!");
            }

            decimal? result = MathService.Subtracao(num1, num2);

            if (result == null)
            {
                return BadRequest("Invalid Input!");
            }

            return Ok(result);
        }

        [HttpGet("multiplicacao/{firstNumber}/{secondNumber}")]
        public IActionResult Multiplicacao(string firstNumber, string secondNumber)
        {
            if (!TryConvertToDecimal(firstNumber, out var num1) ||
            !TryConvertToDecimal(secondNumber, out var num2))
            {
                return BadRequest("Invalid Input!");
            }

            decimal? result = MathService.Multiplicacao(num1, num2);

            if (result == null)
            {
                return BadRequest("Invalid Input!");
            }

            return Ok(result);
        }

        [HttpGet("divisao/{firstNumber}/{secondNumber}")]
        public IActionResult Divisao(string firstNumber, string secondNumber)
        {
            if (!TryConvertToDecimal(firstNumber, out var num1) ||
            !TryConvertToDecimal(secondNumber, out var num2))
            {
                return BadRequest("Invalid Input!");
            }

            decimal? result = MathService.Divisao(num1, num2);

            if (result == null)
            {
                return BadRequest("Invalid Input!");
            }

            return Ok(result);
        }

        [HttpGet("media/{firstNumber}/{secondNumber}")]
        public IActionResult Media(string firstNumber, string secondNumber)
        {
            if (!TryConvertToDecimal(firstNumber, out var num1) ||
             !TryConvertToDecimal(secondNumber, out var num2))
            {
                return BadRequest("Invalid Input!");
            }

            decimal? result = MathService.Media(num1, num2);

            if (result == null)
            {
                return BadRequest("Invalid Input!");
            }

            return Ok(result);
        }

        [HttpGet("raizQuadrada/{number}")]
        public IActionResult RaizQuadrada(string number)
        {
            if (!TryConvertToDecimal(number, out var num))
            {
                return BadRequest("Invalid Input!");
            }

            decimal? result = MathService.RaizQuadrada(num);

            if (result == null)
            {
                return BadRequest("Invalid Input!");
            }

            return Ok(result);
        }
    }
}

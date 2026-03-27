using Microsoft.AspNetCore.Mvc;
using RestWithASPNET10.Service;

namespace RestWithASPNET10.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MathController : ControllerBase
    {


        [HttpGet("soma/{firstNumber}/{secondNumber}")]
        public IActionResult Soma(string firstNumber, string secondNumber)
        {   
            decimal? result = CalculatorService.Soma(firstNumber, secondNumber);

            if (result == null)
            {
                return BadRequest("Invalid Input!");
            }
            return Ok(result);
        }

        [HttpGet("subtracao/{firstNumber}/{secondNumber}")]
        public IActionResult Subtracao(string firstNumber, string secondNumber)
        {
            decimal? result = CalculatorService.Subtracao(firstNumber, secondNumber);

            if (result == null)
            {
                return BadRequest("Invalid Input!");
            }
            return Ok(result);
        }

        [HttpGet("multiplicacao/{firstNumber}/{secondNumber}")]
        public IActionResult Multiplicacao(string firstNumber, string secondNumber)
        {
            decimal? result = CalculatorService.Multiplicacao(firstNumber, secondNumber);

            if (result == null)
            {
                return BadRequest("Invalid Input!");
            }
            return Ok(result);
        }

        [HttpGet("divisao/{firstNumber}/{secondNumber}")]
        public IActionResult Divisao(string firstNumber, string secondNumber)
        {
            decimal? result = CalculatorService.Divisao(firstNumber, secondNumber);

            if (result == null)
            {
                return BadRequest("Invalid Input!");
            }
            return Ok(result);
        }

        [HttpGet("media/{firstNumber}/{secondNumber}")]
        public IActionResult Media(string firstNumber, string secondNumber)
        {
            decimal? result = CalculatorService.Media(firstNumber, secondNumber);

            if (result == null)
            {
                return BadRequest("Invalid Input!");
            }
            return Ok(result);
        }

        [HttpGet("raizQuadrada/{number}")]
        public IActionResult RaizQuadrada(string number)
        {
            decimal? result = CalculatorService.RaizQuadrada(number);

            if (result == null)
            {
                return BadRequest("Invalid Input!");
            }
            return Ok(result);
        }
    }
}

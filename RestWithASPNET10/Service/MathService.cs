using Microsoft.AspNetCore.Http.HttpResults;
using static RestWithASPNET10.Utils.StringToDecimalConverter;

namespace RestWithASPNET10.Service
{
    public static class MathService
    {
        public static decimal? Soma(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public static decimal? Subtracao(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public static decimal? Multiplicacao(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public static decimal? Divisao(decimal firstNumber, decimal secondNumber)
        {
            if (firstNumber == 0 || secondNumber == 0)
            {
                return null;
            }
            return firstNumber / secondNumber;
        }

        public static decimal? Media(decimal firstNumber, decimal secondNumber)
        {
            return (firstNumber + secondNumber) / 2;
        }

        public static decimal? RaizQuadrada(decimal number)
        {
            if (number < 0)
            {
                return null;
            }
            return (decimal)Math.Sqrt((float)number);
        }
    }
}

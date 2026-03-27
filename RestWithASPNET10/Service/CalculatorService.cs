using Microsoft.AspNetCore.Http.HttpResults;
using static RestWithASPNET10.Utils.StringToDecimalConverter;

namespace RestWithASPNET10.Service
{
    public static class CalculatorService
    {
        public static decimal? Soma(string firstNumber, string secondNumber)
        {
            var validX = TryConvertToDecimal(firstNumber, out var x);
            var validY = TryConvertToDecimal(secondNumber, out var y);

            if (!validX || !validY)
            {
                return null;
            }
            return x + y;
        }

        public static decimal? Subtracao(string firstNumber, string secondNumber)
        {
            var validX = TryConvertToDecimal(firstNumber, out var x);
            var validY = TryConvertToDecimal(secondNumber, out var y);

            if (!validX || !validY)
            {
                return null;
            }
            return x - y;
        }

        public static decimal? Multiplicacao(string firstNumber, string secondNumber)
        {
            var validX = TryConvertToDecimal(firstNumber, out var x);
            var validY = TryConvertToDecimal(secondNumber, out var y);

            if (!validX || !validY)
            {
                return null;
            }
            return x * y;
        }

        public static decimal? Divisao(string firstNumber, string secondNumber)
        {
            var validX = TryConvertToDecimal(firstNumber, out var x);
            var validY = TryConvertToDecimal(secondNumber, out var y);

            if (!validX || !validY)
            {
                return null;
            }
            return x / y;
        }

        public static decimal? Media(string firstNumber, string secondNumber)
        {
            var validX = TryConvertToDecimal(firstNumber, out var x);
            var validY = TryConvertToDecimal(secondNumber, out var y);

            if (!validX || !validY)
            {
                return null;
            }
            return (x + y) / 2;
        }

        public static decimal? RaizQuadrada(string number)
        {
            if (!TryConvertToDecimal(number, out var num))
            {
                return null;
            }
            return (decimal)Math.Sqrt((float)num);
        }
    }
}

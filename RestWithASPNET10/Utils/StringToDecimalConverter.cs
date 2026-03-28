using System.Globalization;

namespace RestWithASPNET10.Utils
{
    public static class StringToDecimalConverter
    {
        public static bool TryConvertToDecimal(string value, out decimal result)
        {
            return decimal.TryParse(value, 
                NumberStyles.Any, 
                CultureInfo.InvariantCulture,
                out result);
        }
    }
}

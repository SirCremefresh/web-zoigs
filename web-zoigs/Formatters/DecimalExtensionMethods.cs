using System.Globalization;

namespace Dorflaedali.Formatters
{
    public static class DecimalExtensionMethods
    {
        public static string AsChf(this decimal input)
        {
            return input.ToString("CHF #.00", CultureInfo.InvariantCulture);
        }
    }
}
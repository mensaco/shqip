using System;

namespace Shqip.Helpers
{
    public static class FormatterExtensions
    {
        public static decimal ToDecimal (this string s)
        {
            if (decimal.TryParse(s, out decimal d))
            {
                return d;
            }
            throw new FormatException("Wrong decimal number format");
        }

       

    }
}

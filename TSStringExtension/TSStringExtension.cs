using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSStringExtension
{
    public static class TSStringExtension
    {
        public static string MaskPhoneBySymbol(this string str, char symbol)
        {

            var result = string.Empty;

            if (str.Length != 10)
                return str;

            if (!CheckAllDigital(str))
                return str;
            
            return MaskCenterDigitWithSymbol(str, symbol, result);
        }

        private static string MaskCenterDigitWithSymbol(string str, char symbol, string result)
        {
            return new string(str.Select((x, i) => (i > 3 && i < 7) ? symbol : x).ToArray());
        }

        private static bool CheckAllDigital(string str)
        {
            if (str.All(x => Char.IsDigit(x)))
                return true;
            else
                return false;

        }
    }
}

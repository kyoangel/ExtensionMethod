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

            if (str.Length!=10)
            {
                return str;
            }

            // check all digital
            if (!str.All(x => Char.IsDigit(x)))
            {
                return str;
            }

            for (int i = 0; i < str.Length; i++)
            {
                if (i>3 && i <7)
                {
                    result += symbol;
                }
                else
                {
                    result += str[i];
                }
            }
            return result;
        }
    }
}

﻿using System;
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

            foreach (var character in str)
            {
                int i;
                if (!int.TryParse(character.ToString(), out i))
                {
                    return str;
                }
            }
            return result;
        }
    }
}

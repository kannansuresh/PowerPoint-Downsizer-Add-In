using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Aneejian.PowerPoint.Downsizer.AddIn
{
    internal static class Extensions
    {
        internal static int ToNumber(this string stringToCovnert)
        {
            var numericText = Regex.Replace(stringToCovnert, @"[^\d]", "");
            int.TryParse(numericText, out int result);
            return result;
        }
    }
}
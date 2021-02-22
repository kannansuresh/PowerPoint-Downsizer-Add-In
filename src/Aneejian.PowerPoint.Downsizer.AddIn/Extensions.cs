using System.Text.RegularExpressions;

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
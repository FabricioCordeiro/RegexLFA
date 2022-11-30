using System.Globalization;
using System.Text.RegularExpressions;

namespace RegexLFA;

internal class RgxMoeda
{
    internal static void GetRgxMoeda()
    {
        CultureInfo enUS = CultureInfo.CreateSpecificCulture("en-us");
        NumberFormatInfo nfi = enUS.NumberFormat;

        string pattern = @"^\s*[";
        pattern += Regex.Escape(nfi.PositiveSign + nfi.NegativeSign) + @"]?\s?";
        pattern += Regex.Escape(nfi.CurrencySymbol) + @"?\s?";
        pattern += @"(\d*";
        pattern += Regex.Escape(nfi.CurrencyDecimalSeparator) + "?";
        pattern += @"\d{";
        pattern += nfi.CurrencyDecimalDigits.ToString() + "}?){1}$";

        //pattern contém ^\\s*[\\+-]?\\s?\\$?\\s?(\\d*\\.?\\d{2}?){1}$
        Regex rgx = new(pattern);

        string[] tests = { "-42", "19.99", "0.001", "100 USD",
                         ".34", "0.34", "1.052,21", "Z$10.62",
                         "+1.43", "-$0.23" };

        foreach (string test in tests)
        {
            if (rgx.IsMatch(test))
                Console.WriteLine(" {0} é um valor monetário.", test);
            else
                Console.WriteLine(" {0} não é um valor monetário.", test);
        }
    }
}
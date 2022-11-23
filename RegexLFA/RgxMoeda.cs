using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Text.RegularExpressions;

namespace RegexLFA;

internal class RgxMoeda
{
    internal static void GetRgxMoeda()
    {
        //Especifica a cultura utilizada
        CultureInfo enUS = CultureInfo.CreateSpecificCulture("en-us");
        //Especifica o formato da moeda da cultura especificada
        NumberFormatInfo nfi = enUS.NumberFormat;

        // Defina o padrão de expressão regular.
        string pattern = @"^\s*[";
        // Obtenha os símbolos de sinal positivo e negativo.
        pattern += Regex.Escape(nfi.PositiveSign + nfi.NegativeSign) + @"]?\s?";
        // Obtenha o símbolo da moeda.
        pattern += Regex.Escape(nfi.CurrencySymbol) + @"?\s?";
        // Adicione dígitos integrais ao padrão.
        pattern += @"(\d*";
        // Add the decimal separator.
        pattern += Regex.Escape(nfi.CurrencyDecimalSeparator) + "?";
        // Adicione o separador decimal.
        pattern += @"\d{";
        // Determine o número de dígitos fracionários em valores de moeda.
        pattern += nfi.CurrencyDecimalDigits.ToString() + "}?){1}$";

        //pattern contém ^\\s*[\\+-]?\\s?\\$?\\s?(\\d*\\.?\\d{2}?){1}$
        Regex rgx = new Regex(pattern);

        // Defina algumas strings de teste.
        string[] tests = { "-42", "19.99", "0.001", "100 USD",
                         ".34", "0.34", "1.052,21", "Z$10.62",
                         "+1.43", "-$0.23" };

        // Verifique cada string de teste em relação à expressão regular.
        foreach (string test in tests)
        {
            if (rgx.IsMatch(test))
                Console.WriteLine(" {0} é um valor monetário.", test);
            else
                Console.WriteLine(" {0} não é um valor monetário.", test);
        }
    }
}


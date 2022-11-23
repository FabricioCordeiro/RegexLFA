using System.Text.RegularExpressions;

namespace RegexLFA;
#pragma warning disable CS8604

internal class RgxCPF
{
    public static void GetRgxCPF()
    {
        Console.Write("Informe um cpf para validação: ");
        var texto = Console.ReadLine();

        Regex rgx = new(@"([0-9]{4}[-]?[0-9]{2})|([0-9]{3}[\.]?[0-9]{3}[\.]?[0-9]{3}[-]?[0-9]{2})", 
            RegexOptions.IgnorePatternWhitespace);
        
        if (rgx.IsMatch(texto))
            Console.WriteLine("CPF válido.");
        else
            Console.WriteLine("CPF inválido.");
    }
}
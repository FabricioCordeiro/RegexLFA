using System.Text.RegularExpressions;

namespace RegexLFA;
#pragma warning disable CS8604

//https://www.alura.com.br/artigos/regex-c-sharp-utilizar-expressoes-regulares?gclid=Cj0KCQiA4OybBhCzARIsAIcfn9l3TOkp8alTjHVZ6jiBSGJTeegVBA8Gy7JT8xo4OMSIpkxkBUpcrd4aAq-LEALw_wcB
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
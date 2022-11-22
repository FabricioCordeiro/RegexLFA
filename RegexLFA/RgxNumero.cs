using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexLFA;
#pragma warning disable CS8604

internal class RgxNumero
{
    //https://www.alura.com.br/artigos/regex-c-sharp-utilizar-expressoes-regulares?gclid=Cj0KCQiA4OybBhCzARIsAIcfn9l3TOkp8alTjHVZ6jiBSGJTeegVBA8Gy7JT8xo4OMSIpkxkBUpcrd4aAq-LEALw_wcB
    public static void GetRgxNumero()
    {
        Console.Write("Informe um valor:  ");
        var caracteres = Console.ReadLine();

        bool test = Regex.IsMatch(caracteres, "^[0-9]+$");

        if (!test)
            Console.WriteLine("O valor informado não é um numérico válido.");
        else
            Console.WriteLine("O valor informado é válido.");
    }
}

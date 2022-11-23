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

using System.Text.RegularExpressions;

namespace RegexLFA;

//https://www.c-sharpcorner.com/article/c-sharp-regex-examples/
internal class RgxReplace
{
    public static void GetRgxReplace()
    {
        // Uma string longa com toneladas de espaços em branco  
        string comEspaco = "Aqui    está uma   string com muitos    espaços em branco.";
        Console.WriteLine($" Com espaço: {comEspaco}\n");

        string semEspaco = Regex.Replace(comEspaco, "\\s+", "");
        Console.WriteLine($" Sem espaço: {semEspaco}");
    }
}

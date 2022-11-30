Imports System.Text.RegularExpressions

Public Class RgxReplace
    Public Shared Sub GetRgxReplace()
        Dim comEspaco = "Aqui    está uma   string com muitos    espaços em branco."
        Console.WriteLine($" Com espaço: {comEspaco}")

        Dim semEspaco = Regex.Replace(comEspaco, "\s+", "")
        Console.WriteLine($" Sem espaço: {semEspaco}")
    End Sub
End Class


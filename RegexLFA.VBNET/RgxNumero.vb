Imports System.Text.RegularExpressions

Public Class RgxNumero
    Public Shared Sub GetRgxNumero()
        Console.Write("Informe um valor:  ")
        Dim caracteres = Console.ReadLine()

        Dim test As Boolean = Regex.IsMatch(caracteres, "^[0-9]+$")

        If (test) Then
            Console.WriteLine("O valor informado � v�lido.")
        Else
            Console.WriteLine("O valor informado n�o � um num�rico v�lido.")
        End If
    End Sub
End Class

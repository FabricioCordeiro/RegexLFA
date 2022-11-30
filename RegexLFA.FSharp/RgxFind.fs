namespace RegexLFA.FSharp

open System.Text.RegularExpressions

module RgxFind =
    let users = ["Vitor"; "Thomas"; "Robert";
        "Lucy"; "Beky"; "Sanderson"; "Peter"; "Andy"; "Fabricio"]

    let GetRgxFind = Regex("Fabricio|Sanderson|Vitor", RegexOptions.Compiled)
    users |> List.filter GetRgxFind.IsMatch |> List.iter (printfn "-> %s")


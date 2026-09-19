open System

[<EntryPoint>]
let main argv =
    let nameProgram = "WindowsXP's Console"

    Console.Title <- nameProgram
    Console.ForegroundColor <- ConsoleColor.White
    Console.BackgroundColor <- ConsoleColor.DarkBlue
    Console.Clear()

    let rec loop () =
        Console.Write("TheSl>")
        let inp = Console.ReadLine()
        // aqui você coloca a lógica do console (funções, ifs, modularização etc.)
        loop ()

    loop ()
    0 // código de saída

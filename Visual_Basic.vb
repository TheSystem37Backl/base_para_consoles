Namespace RN

    Module Rn1
        Const NameProgram As String = "WindowsXP's Console"

        Sub Main()
            Console.Title = NameProgram
            Console.ForegroundColor = ConsoleColor.White
            Console.BackgroundColor = ConsoleColor.DarkBlue
            Console.Clear()

            While True
                Console.Write("TheSl>")
                Dim inp As String = Console.ReadLine()
                ' aqui voce bota a logica do console (seja em funcao, logica em if, ou modular)
            End While
        End Sub
    End Module
End Namespace

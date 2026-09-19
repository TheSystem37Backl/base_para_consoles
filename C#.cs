using System;

namespace RN
{
    class Rn1
    {
        const string NameProgram = "WindowsXP's Console";

        static void Main()
        {
            Console.Title = NameProgram;
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();

            while (true)
            {
                Console.Write("TheSl>");
                string inp = Console.ReadLine();
                // aqui você coloca a lógica do console (funções, ifs, modularização etc.)
            }
        }
    }
}

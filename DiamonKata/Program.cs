using System;

namespace DiamondKata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(DiamondPrinter.PrintFromConsoleInput());
            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
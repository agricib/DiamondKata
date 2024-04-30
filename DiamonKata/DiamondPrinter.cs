using System;
using System.Text;

namespace DiamondKata
{
    public static class DiamondPrinter
    {
        public static string Print(char letter)
        {
            letter = char.ToUpper(letter);

            var diamond = new StringBuilder();
            var distance = letter - 'A';

            // Upper part of the diamond
            for (char currentLetter = 'A'; currentLetter <= letter; currentLetter++)
            {
                diamond.Append(GenerateLine(currentLetter, distance));
                diamond.Append("\n");
                distance--;
            }

            // Lower part of the diamond
            distance = 1;
            for (char currentLetter = (char)(letter - 1); currentLetter >= 'A'; currentLetter--)
            {
                diamond.Append(GenerateLine(currentLetter, distance));
                diamond.Append("\n");
                distance++;
            }

            return diamond.ToString().TrimEnd();
        }

        private static string GenerateLine(char currentLetter, int distance)
        {
            var line = new StringBuilder();
            line.Append(' ', distance); // Leading spaces
            line.Append(currentLetter); // Left half
            if (currentLetter != 'A')
            {
                var innerSpaces = (currentLetter - 'A') * 2 - 1;
                if (innerSpaces > 0)
                {
                    line.Append(' ', innerSpaces); // Inner spaces
                    line.Append(currentLetter); // Right half
                }
            }

            return line.ToString();
        }

        public static string PrintFromConsoleInput()
        {
            char input;
            do
            {
                Console.WriteLine("Enter a letter: ");
                input = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if (!char.IsLetter(input))
                {
                    Console.WriteLine("Please enter a letter not other characters.");
                }
            } while (!char.IsLetter(input));

            return Print(input);
        }
    }
}

using System;

namespace PasswordGenerator
{
    internal class Program
    {
        static Random random = new Random();
        private static void Main(string[] args)
        {
            run();
        }

        private static void run()
        {
            Console.WriteLine("Entrée un chiffre ou Q pour quitté");
            string entry = Console.ReadLine();
            try
            {
                if (String.Equals(entry.ToUpper(),"Q"))
                {
                  Environment.Exit(0);
                }
                else if (entry.Length == 0 || entry.Contains(" "))
                {
                    run();
                }
                int length = Int32.Parse(entry);
                Console.WriteLine(GeneratePassWords(length));
                run();
            }
            catch (FormatException)
            {
                Console.WriteLine("Impossible a parse");
                run();
            }
        }

        private static String GeneratePassWords(int length)
        {
            string charlist = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMOPQRSTYVWXYZ1234567890^$£àéèç_\\-*+%ùµ?,.;/:§!";
            int longueur = charlist.Length - 1;
            var chars = new char[length];
            for (var i = 0; i < length; i++)
            {
                chars[i] = charlist[random.Next(0, longueur)];
            }
            return new String(chars);
        }
    }
}
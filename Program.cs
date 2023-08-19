using System;

namespace TehtavaB5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pyydetään käyttäjältä x ja y arvot
            Console.Write("Syötä x-arvo: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Syötä y-arvo: ");
            int y = int.Parse(Console.ReadLine());

            // Lasketaan x = x % y
            x = x % y;

            // Tulostetaan tulos
            Console.WriteLine("x = " + x);
        }
    }
}

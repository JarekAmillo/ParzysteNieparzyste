using System;

namespace Tydz4ZadDom1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Tydzień czwarty, zadanie domowe numer 1\n");
            Console.ResetColor();

            Console.WriteLine("Podaj dowolną liczbę parzystą");

            try
            {
                var userNumber = int.Parse(Console.ReadLine());
                if (userNumber % 2 == 0)
                {
                    Console.WriteLine($"Brawo! wskazana przez Ciebie liczba {userNumber} jest parzysta.");
                }
                else
                {
                    Console.WriteLine("Wskazana przez Ciebie liczba nie jest parzysta, wskaż ponownie liczbę.");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}

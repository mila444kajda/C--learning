using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwszą liczbę: ");
            int liczba1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę: ");
            int liczba2 = Convert.ToInt32(Console.ReadLine());

            int z = Dzielenie(liczba1, liczba2);

            Console.WriteLine("Twój wynik to: " + z);

            Console.ReadKey();

            static int Dzielenie(int L1, int L2)
            {

                int wynik = L1 / L2;

                return wynik;
            }
        }
    }
}
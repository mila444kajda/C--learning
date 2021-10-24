using System;

namespace Kalkulator_Total
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj działanie: 1. Dodawanie, 2. Odejmowanie, 3. Mnożenie, 4. Dzielenie");
            int dzialanie = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj pierwszą liczbę: ");
            int liczba1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę: ");
            int liczba2 = Convert.ToInt32(Console.ReadLine());

            if (dzialanie == 1)
            {
                int Dodawanie = liczba1 + liczba2;

                Console.WriteLine("Twój wynik to: " + Dodawanie);

                Console.ReadKey();
            }

            else if (dzialanie == 2) ;
            {
                int Odejmowanie = liczba1 - liczba2;

                Console.WriteLine("Twój wynik to: " + Odejmowanie);

                Console.ReadKey();
            }

            else if (dzialanie == 3) ;
            {
                int Mnozenie = liczba1 * liczba2;

                Console.WriteLine("Twój wynik to: " + Mnozenie);

                Console.ReadKey();
            }

            else if (dzialanie == 4) ;
            {
                int Dzielenie = liczba1 * liczba2;

                Console.WriteLine("Twój wynik to: " + Dzielenie);

                Console.ReadKey();
            }

        }

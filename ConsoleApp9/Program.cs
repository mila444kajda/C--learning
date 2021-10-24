using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Dodawanie());
            Console.ReadKey();
        }
        static int Dodawanie()
        {
            Console.WriteLine("Podaj pierwszą liczbę: ");
            int liczba1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę: ");
            int liczba2 = Convert.ToInt32(Console.ReadLine());

            int wynik = liczba1 + liczba2;
            Console.WriteLine("Twój wynik to: ");
            return wynik;

        }








    }


}

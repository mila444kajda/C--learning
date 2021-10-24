using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            //zadanka - najmniejsza i największa liczba

            Console.WriteLine("Podaj pierwszą liczbę: ");
            int liczba1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę: ");
            int liczba2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj trzecią liczbę: ");
            int liczba3 = int.Parse(Console.ReadLine());

            int[] Liczby = new int[3] { liczba1, liczba2, liczba3 };
            

                         
            Console.ReadKey();
        }
    }
    
}

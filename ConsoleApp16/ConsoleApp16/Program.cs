using System;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwszą liczbę: ");
            float x = float.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę: ");
            float y = float.Parse(Console.ReadLine());

            Calculator calculator1 = new Calculator();
            Console.WriteLine(calculator1.Dodawanie(x, y));
            Console.WriteLine(calculator1.Odejmowanie(x, y));
            Console.WriteLine(calculator1.Mnozenie(x, y));
            Console.WriteLine(calculator1.Dzielenie(x, y));
                    }
    }
}

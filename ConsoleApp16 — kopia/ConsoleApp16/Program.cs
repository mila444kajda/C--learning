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
            calculator1.Dodawanie(x, y);
            calculator1.Odejmowanie(x, y);
            calculator1.Mnozenie(x, y);
            calculator1.Dzielenie(x, y);

            Calculator_Model CalcModel2 = calculator1.GetResults();
            Console.WriteLine(CalcModel2.wynik_dodawania);
            Console.WriteLine(CalcModel2.wynik_odejmowania);
            Console.WriteLine(CalcModel2.wynik_mnozenia);
            Console.WriteLine(CalcModel2.wynik_dzielenia);
        }
    }
}

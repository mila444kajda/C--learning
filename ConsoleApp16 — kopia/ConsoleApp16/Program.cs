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

            Calculator_Model CalcModel3 = new Calculator_Model();

            Calculator calculator1 = new Calculator(CalcModel3);

            CalcModel3 = calculator1.GetResults(x, y);

            Console.WriteLine(CalcModel3.wynik_dodawania);
            Console.WriteLine(CalcModel3.wynik_odejmowania);
            Console.WriteLine(CalcModel3.wynik_mnozenia);
            Console.WriteLine(CalcModel3.wynik_dzielenia);
        }
    }
}

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

            Calculator_Model CalcModel = new Calculator_Model();

            Calculator calc = new Calculator(CalcModel);

            CalcModel = calc.GetResults(x, y);

            Console.WriteLine(CalcModel.wynik_dodawania);
            Console.WriteLine(CalcModel.wynik_odejmowania);
            Console.WriteLine(CalcModel.wynik_mnozenia);
            Console.WriteLine(CalcModel.wynik_dzielenia);
        }
    }
}

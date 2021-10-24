using System;

namespace ConsoleApp16
{
    class Calculator
    {
        Calculator_Model CalcModel1 = new Calculator_Model();
                
        public void Dodawanie(float x, float y)
        {
            CalcModel1.wynik_dodawania = x + y;
            
        }

        public void Odejmowanie(float x, float y)
        {
            CalcModel1.wynik_odejmowania = x - y;
        }

        public void Mnozenie(float x, float y)
        {
            CalcModel1.wynik_mnozenia = x * y;
        }

        public void Dzielenie(float x, float y)
        {
            CalcModel1.wynik_dzielenia = x / y;
        }
        public Calculator_Model GetResults()
        {
            return CalcModel1;
        }

    }
}   


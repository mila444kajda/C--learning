using System;

namespace ConsoleApp16
{
    class Calculator
    {
        private readonly Calculator_Model _calculator_Model;

        public Calculator(Calculator_Model calculator_Model)
        {
            _calculator_Model = calculator_Model;
        }
                
        private void Dodawanie(float x, float y)
        {
            _calculator_Model.wynik_dodawania = x + y;
            
        }

        private void Odejmowanie(float x, float y)
        {
            _calculator_Model.wynik_odejmowania = x - y;
        }

        private void Mnozenie(float x, float y)
        {
            _calculator_Model.wynik_mnozenia = x * y;
        }

        private void Dzielenie(float x, float y)
        {
            _calculator_Model.wynik_dzielenia = x / y;
        }
        public Calculator_Model GetResults(float x, float y)
        {
            Dodawanie(x, y);
            Odejmowanie(x, y);
            Mnozenie(x, y);
            Dzielenie(x, y);
            return _calculator_Model;
        }

    }
}   


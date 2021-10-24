using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int wynik = 1;
            int liczba = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= liczba; i++)
            {
                wynik = wynik * i;
            }

            Console.WriteLine("Silnia to: "+wynik);
            Console.ReadKey();
        }
    }
}

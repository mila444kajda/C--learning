using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczba = Convert.ToInt32(Console.ReadLine());
            int liczba2 = Convert.ToInt32(Console.ReadLine());
            int wynik = liczba * liczba2;

            Console.WriteLine("Pole prostokąta to: " + wynik);
            Console.ReadKey();
        }
       
    }
     
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] liczby = new int[5];
            for (int i = 0; i < 5; i++)
                liczby[i] = Convert.ToInt32(Console.ReadLine());
            for (int j = 0; j < 5; j++)
            {   
                bool isPrime = true;

                for (int i = 2; i < liczby[j]; i++)
                {
                    if (liczby[j] % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)

                    Console.WriteLine("Liczba jest liczbą pierwszą");
                else
                    Console.WriteLine("Liczba nie jest liczbą pierwszą");
            }
            Console.ReadKey();
        }
    }
}

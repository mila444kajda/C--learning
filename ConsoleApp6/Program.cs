using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczba = Convert.ToInt32(Console.ReadLine());
            bool isPrime = true;

            for (int i = 2; i < liczba; i++)
            {
                if (liczba % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)

                Console.WriteLine("Liczba jest liczbą pierwszą");
            else
                Console.WriteLine("Liczba nie jest liczbą pierwszą");
            Console.ReadKey();

        }
    }
}

    
    


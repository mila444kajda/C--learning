using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
  
            string[] moja_rodzina = { "Waldek", "Wikuś", "Grześ", "Mama", "Tata", "Piotrek", "ja" };

            for (int i = 0; i < moja_rodzina.Length; i++)
            {
                Console.WriteLine(moja_rodzina[i]);
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Num_4_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number:");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine("{0} {0} {0} {0}", num);
                
                Console.WriteLine("{0}{0}{0}{0}", num);
            }
            Console.ReadKey(); 
        }
    }
}

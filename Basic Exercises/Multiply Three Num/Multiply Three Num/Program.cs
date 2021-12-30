using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_Three_Num
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first num:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second num:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter third num:");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(a * b * c);
            Console.ReadKey();

        }
    }
}

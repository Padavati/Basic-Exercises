using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddSubMulDiv
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("First Num:");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Second Num:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(a+b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);

            Console.ReadKey();
        }
    }
}

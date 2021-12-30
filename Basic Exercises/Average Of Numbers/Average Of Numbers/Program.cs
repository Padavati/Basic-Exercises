using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_Of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first num:");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter second num:");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Enter third num:");
            int c = int.Parse(Console.ReadLine());

            Console.Write("Enter fourth num:");
            int d = int.Parse(Console.ReadLine());

            int sum = a + b + c + d;
            int avg = sum / 4;

            Console.WriteLine("The avg of {0},{1},{2},{3} is: {4}",a,b,c,d,avg);
            Console.ReadKey();
        }
    }
}

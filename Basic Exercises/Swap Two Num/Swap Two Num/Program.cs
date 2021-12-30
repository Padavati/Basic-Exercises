using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap_Two_Num
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Number=");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Second Number=");
            int b = Convert.ToInt32(Console.ReadLine());

            //After Swapping
            int c;
            c = a;
            a = b;
            b = c;
            Console.WriteLine("After Swapping:");
            Console.WriteLine("First Number="+ a);
            Console.WriteLine("Second Number="+ b);

            Console.ReadKey();

        }
    }
}

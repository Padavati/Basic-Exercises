using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Take_Three_Num_print_as
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write( "Ener first num:");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Ener second num:");
            int y = int.Parse(Console.ReadLine());

            Console.Write("Ener third num:");
            int z = int.Parse(Console.ReadLine());

            int a = (x + y)*z;
            int b = x * y + y*z;

            Console.WriteLine("Result of specified numbers {0},{1} and {2},(x+y).z is {3} and x.y+y.z is {4}",x,y,z,a,b);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Num_3C_5R
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a digit:");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{0}{0}", num);
            for(int i=0;i<=2;i++)
            {
                Console.WriteLine("{0} {0}", num);
            }
            Console.WriteLine("{0}{0}{0}", num);
            Console.ReadKey();
        }
    }
}

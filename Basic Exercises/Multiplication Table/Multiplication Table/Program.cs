using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number:");
            int a = int.Parse(Console.ReadLine());
            
            for(int i=1;i<=10;i++)
            {
                int res = a * i;
                Console.WriteLine("{0}*{1}={2}",a,i,res);     
            }
            Console.ReadKey();
        }
    }
}

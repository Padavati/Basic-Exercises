using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("You look older than {0}", age);
            Console.ReadKey();
        }
    }
}

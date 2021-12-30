using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celcius_To_KelvinFaurenheat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the amount of celcius:");
            int celcius = int.Parse(Console.ReadLine());

            Console.WriteLine("Kelvin={0}" ,celcius+273);
            Console.WriteLine("Faurenheit={0}" , celcius * 18 / 10 + 32);

            Console.ReadKey();
        }
    }
}

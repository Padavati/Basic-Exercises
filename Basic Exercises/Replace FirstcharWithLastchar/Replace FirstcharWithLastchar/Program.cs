using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Replace_FirstcharWithLastchar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> arr = new List<string>();
            arr.Add("w3resource");
            arr.Add("Python");
            arr.Add("x");

            string temp = arr[0];
            arr[0] = arr[arr.Count - 1];
            arr[arr.Count - 1] = temp;

            Console.WriteLine(arr[0]+ temp);

            Console.ReadKey();

        }
    }
}

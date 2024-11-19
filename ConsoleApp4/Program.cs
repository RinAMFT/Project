using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static double Func(int x)
        { 
            return 3 * (Math.Pow(x, 2))+5*x+1;
        }

        static void Main(string[] args)
        {
            Console.Write("x=");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine($"y={Func(x):f2}");
            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        /// <summary>
        /// func
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Write("x=");
            int  x = int.Parse(Console.ReadLine());
            //double rez = Func(x);
            //Console.WriteLine($"rez={rez:f2}");
            Console.WriteLine($"rez={Func(x):f2}");
            Console.ReadLine();
        }
        static double Func(int x)
        {
            return Math.Pow(x, 2);
        }
    }
}

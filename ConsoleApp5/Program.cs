using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static double Funk(int x)
        {
            //if (x>=0)
            //{
            //    return 3*Math.Pow(x,2);
            //}
            //else 
            //{
            //    return x + 1;
            //}
            return (x >= 0) ? x*x*3 : x + 1;
            
        }
        static void Main(string[] args)
        {
            
            Console.Write("x=");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine($"y={Funk(x)}");
            Console.ReadKey();
        }
    }
}

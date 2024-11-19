using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        public static int Sum(int x, int y)
        {
        return x+y;
        }
        public static int Raz(int x, int y)
        {
            return x - y;
        }
        public static int Umn(int x, int y)
        {
            return x * y;
        }
        public static double Del(int x, int y)
        {
            return (double) x / y;
        }
        static void Main(string[] args)
        {
        Console.Write("x=");
        int x = int.Parse(Console.ReadLine());
        Console.Write("y=");
        int y = int.Parse(Console.ReadLine());
        Console.WriteLine($"sum={Sum(x, y)}\t raz={Raz(x, y)}\t umn={Umn(x, y)}\t del={Del(x, y)}");
         Console.ReadKey();
    }
    }
}

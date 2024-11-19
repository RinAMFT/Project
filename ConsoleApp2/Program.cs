using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    /// <summary>
    /// вычислить значение функции
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// функция
        /// </summary>
        static void Func()
        {
            
            Console.Write("x=");
            int x = int.Parse(Console.ReadLine());
            double y = Math.Pow(x, 2);
            Console.WriteLine($"y={y:f2}");
        }
        /// <summary>
        /// основной метод
        /// </summary>
        /// <param name="args"></param>
    static void Main(string[] args)
        {
            Func();
            Func();
            Func();
            Console.ReadLine();
        }
        
    }
}

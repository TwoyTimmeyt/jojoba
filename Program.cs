using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static int Function(int x)
        {
            int y = x ^ 2;
            Console.WriteLine($"x={x}, y={y}");
            return y;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите начальное значение x");
            int nach = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите конечное значение x");
            int kon = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите шаг построения");
            int shag = int.Parse(Console.ReadLine());
            int a, b;
            a = nach;
            b = 0;
            while (a >= nach & a < kon)
            {
                if (a < kon & a + shag > kon)
                {
                    a = kon;
                Function(a);
                }
                else
                {
                    a = nach + shag * b;
                    b = b + 1;
                    Function(a);
                }
            } 
            Console.ReadKey();
        }
    }
}

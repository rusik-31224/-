using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сбор_статистики
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3; // целая часть среднего арифметического матрицы t
            int b = 2; // целая часть среднего арифметического матрицы d

            double D = Math.Pow(2 * a, 2) - 4 * 3 * b; // вычисляем дискриминант

            if (D < 0)
            {
                Console.WriteLine("Уравнение не имеет действительных корней");
            }
            else if (D == 0)
            {
                double x = -(2 * a) / (2 * 3);
                Console.WriteLine($"Уравнение имеет единственный корень: x = {x}");
            }
            else
            {
                double x1 = (-2 * a + Math.Sqrt(D)) / (2 * 3);
                double x2 = (-2 * a - Math.Sqrt(D)) / (2 * 3);
                Console.WriteLine($"Уравнение имеет два корня: x1 = {x1}, x2 = {x2}");
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длины строн треугольника N1 (завершение ввода - нажатие Enter):");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            double S = Math.Round(GetSquare(a, b, c), 2);
            Console.WriteLine();

            Console.WriteLine("Введите длины строн треугольника N2 (завершение ввода - нажатие Enter):");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            double S1 = Math.Round(GetSquare(a, b, c), 2);
            Console.WriteLine();

            if (S > S1)
                Console.WriteLine("Площадь первого треугольника больше площади второго треугольника: {0} > {1}", S, S1);
            else
            {
                if (S < S1)
                    Console.WriteLine("Площадь второго треугольника больше площади первого треугольника: {0} > {1}", S1, S);
                else Console.WriteLine("Площади треугольников равны");
            }
            Console.ReadKey();
        }
        static double GetSquare(int a, int b, int c)
        {
            double P = (a + b + c) / 2;
            double S = Math.Sqrt(P * (P - a) * (P - b) * (P - c));
            return S;
        }

    }
}

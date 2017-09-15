using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2_Day2
{
    class Task2
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите коордионаты первой(A) вершины треугольника.");
            Console.Write("x1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Введите коордионаты второй(B) вершины треугольника.");
            Console.Write("x2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Введите коордионаты третьей(C) вершины треугольника.");
            Console.Write("x3: ");
            double x3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y3: ");
            double y3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            double a = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            double b = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));
            double c = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));

            if (a <= b + c && b <= a + c && c <= a + b)
            {
                double p = (a + b + c) / 2;

                double S = Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
                Console.WriteLine("Площадь треугольника S = {0:0.0000}", S);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Одна сторона треугольника больше суммы двух других сторон.\nТакой треугольник не может существовать.");
                Console.WriteLine();
            }

            // задача уже с установленными значениями(закоментировать верхний код раскоментировав второй)
            //double x1 = 19.8, y1 = 21.5;
            //double x2 = 8, y2 = 5;
            //double x3 = 20, y3 = 24;

            //double a = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            //double b = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));
            //double c = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));

            //Console.WriteLine("Сторона А = {0:0.0000}", a);
            //Console.WriteLine("Сторона B = {0:0.0000}", b);
            //Console.WriteLine("Сторона C = {0:0.0000}", c);
            //Console.WriteLine();

            //if (a <= b + c && b <= a + c && c <= a + b) {
            //    double p = (a + b + c) / 2;
            //    Console.WriteLine("Полупириметр p = {0:0.0000}", p);
            //    Console.WriteLine();

            //    double S = Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
            //    Console.WriteLine("Площадь треугольника = {0:0.0000}", S);
            //    Console.WriteLine();
            //}
            //else {
            //    Console.WriteLine("Одна сторона треугольника больше суммы двух других сторон.\nТакой треугольник не может существовать.");
            //    Console.WriteLine();
            //}
        }
    }
}

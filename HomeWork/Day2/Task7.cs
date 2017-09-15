using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7_Day2
{
    class Task7
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число A: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число B (число должно быть больше числа A): ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            for (int i = a; i <= b; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}

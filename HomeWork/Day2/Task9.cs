using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9_Day2
{
    class Task9
    {
        static void Main(string[] args)
        {
            Console.Write("Введите высоту фигуры: ");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите длину фигуры: ");
            int length = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите символ контура фигуры: ");
            string circuit = Console.ReadLine();

            Console.Write("Введите символ заливки фигуры: ");
            string casting = Console.ReadLine();

            for (int i = 0; i < height; i++)
            {
                if (i == 0 || i == height - 1)
                {
                    for (int j = 0; j < length; j++)
                    {
                        Console.Write(circuit);
                    }
                }
                else
                {
                    Console.Write(circuit);
                    for (int j = 1; j < length - 1; j++)
                    {
                        Console.Write(casting);
                    }
                    Console.Write(circuit);
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}

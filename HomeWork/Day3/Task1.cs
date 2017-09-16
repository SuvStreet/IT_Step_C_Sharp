using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1_Day3
{
    class Task1
    {
        static void Main(string[] args)
        {
            double index = 1;

            int[] A = new int[5];

            int rows = 4;
            int column = 3;
            double[,] B = new double[column, rows];
            
// работа с одномерным массивом

            // инициализация массива A (вручную)
            for (int i = 0; i < A.Length; i++, index++)
            {
                Console.Write("Введите {0} число массива: ", index);
                A[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();
            Console.Write("Ваш массив A чисел: ");
            Console.WriteLine(String.Join(" ", A));

            // Максимальный элемент в массиве A
            Console.WriteLine("Максимальный элемент в массиве A: " + A.Max());

            // Сумма элементов массива A
            Console.WriteLine("Сумма элементов массива A: " + A.Sum());

            // Произведение элементов массива A
            index = 1;
            for (int i = 0; i < A.Length; i++)
            {
                index *= A[i];
            }
            Console.WriteLine("Произведение элементов массива A: " + index);

            // сумму четных элементов массива А
            index = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 0)
                {
                    index += A[i];
                }
            }
            Console.WriteLine("сумму четных элементов массива А: " + index);

// Работа с двумерным массивом

            // Инициализация двумерного массива (рандомные числа)
            Console.WriteLine();
            Console.WriteLine("Ваш массив B чисел: ");
            
            Random rnd = new Random();
            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    B[i, j] = rnd.Next(0, 100);
                    Console.Write(B[i, j] + " ");
                }
                Console.WriteLine();
            }

            // максимальный элемент массива B
            index = 0;
            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (index < B[i, j])
                    {
                        index = B[i, j];
                    }
                }
            }
            Console.WriteLine("Максимальный элемент в массиве B: " + index);

            // сумма элементов массива B
            index = 0;
            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    index += B[i, j];
                }
            }
            Console.WriteLine("Сумма элементов массива B: " + index);

            // произведение элементов массива B
            index = 1;
            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    index *= B[i, j];
                }
            }
            Console.WriteLine("Произведение элементов массива B: " + index);

            // сумму нечетных столбцов массива В
            index = 0;
            int row = 1;
            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < rows; j++, row++)
                {
                    if (row % 2 != 0)
                    {
                        index += B[i, j];
                    }
                }
            }
            Console.WriteLine("Сумма нечетных столбцов массива В: " + index);

            Console.Read();
        }
    }
}

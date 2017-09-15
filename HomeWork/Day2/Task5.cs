using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5_Day2
{
    class Task5
    {
        static void Main(string[] args)
        {
            int i = 1;
            int counter = 0;
            int suma = 0;
            int number = 0;

            Console.WriteLine("Введите число (0 - это выход).");

            bool flag = false;

            while (flag == false)
            {
                try
                {
                    Console.Write("Число {0} = ", i);
                    number = Convert.ToInt32(Console.ReadLine());
                    i++;
                }
                catch (Exception)
                {
                    Console.WriteLine("\nВведите число!\n");
                    continue;
                }

                if (number == 0) { flag = true; }
                else
                {
                    counter++;
                    suma += number;
                }
            }
            Console.WriteLine("\nКоличество введенных чисел: {0}", counter);
            Console.WriteLine("Общяя сумма: {0}", suma);
            Console.WriteLine("Среднее арифметическое: {0}", (suma / (counter)));
            Console.ReadLine();
        }
    }
}

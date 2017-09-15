using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6_Day2
{
    class Task6
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер трамвайного билета (6-значное число): ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number / 1000000 == 0)
            {
                int leftSum = 0;
                int rightSum = 0;

                for (int i = 0; i < 7; i++)
                {
                    if (i < 3)
                    {
                        rightSum += number % 10;
                        number = number / 10;
                    }
                    else
                    {
                        leftSum += number % 10;
                        number = number / 10;
                    }
                }

                if (rightSum == leftSum)
                {
                    Console.WriteLine("У вас счастливый билет: {0} = {1}", rightSum, leftSum);
                }

                else Console.WriteLine("У вас не счастливый билет: {0} != {1}", rightSum, leftSum);
            }
            else Console.WriteLine("Число введено не правильно!");
            
            Console.Read();
        }
    }
}

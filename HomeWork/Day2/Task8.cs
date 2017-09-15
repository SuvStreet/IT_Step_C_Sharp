using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8_Day2
{
    class Task8
    {
        static void Main(string[] args)
        {
            Console.Write("Все совершенные чисела до 10,000: ");

            for (int i = 1; i <= 10000; i++)
            {
                int n = i;
                int summa = 0;
                for (int k = 1; k < n; k++)
                    if (i % k == 0)
                    {
                        summa = summa + k;
                    }
                if (n == summa)
                    Console.Write(n + " ");
            }
            Console.WriteLine();
            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4_Day2
{
    class Task4
    {
        static void Main(string[] args)
        {
            double proc;
            Console.Write("Введите процент по вкладу (больше 0, но не более 25%): ");
            proc = Convert.ToDouble(Console.ReadLine());
            
            if (proc < 0 || proc > 25)
            {
                Console.WriteLine("Нереальный процент :)");
                Console.ReadKey();
                Environment.Exit(0);
            }

            double deposit = 1000;
            int count = 0;
            while (deposit < 1100)
            {
                deposit += deposit * proc / 100;
                count++;
            }
            Console.WriteLine("До превышения лимита вклада на сумму 1100р. понадобится: {0} месяц(-а/-ев) \nсумма вклада составит: {1} руб.", count, deposit);
            Console.ReadLine();
        }
    }
}

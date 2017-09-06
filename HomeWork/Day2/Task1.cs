using System;

namespace Task1 {
    class Program {
        static void Main(string[] args) {

            Console.Write("Введите единицу измерения температуры: ");
            string str = Console.ReadLine();
            Console.WriteLine();

            double temperatureF, temperatureC;

            if (str == "F" || str == "f")
            {
                Console.Write("Введите температуру в Фаренгейтах(F): ");
                temperatureF = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();

                temperatureC = (temperatureF - 32.0) * 5.0 / 9.0;
                Console.WriteLine("Температура в Цельсия(C): {0:0.00}", temperatureC);
                Console.WriteLine();
            }
            if (str == "C" || str == "c")
            {
                Console.Write("Введите температуру в Цельсия(C): ");
                temperatureC = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();

                temperatureF = (temperatureC * 9.0 / 5.0) + 32.0;
                Console.WriteLine("Температура в Фаренгейтах(F): {0:0.00}", temperatureF);
                Console.WriteLine();
            }

            // задача уже с установленными значениями(закоментировать верхний код раскоментировав второй)
            //double temperatureF = 98;
            //double temperatureC;
            //Console.WriteLine(temperatureC = (temperatureF - 32.0) * 5.0 / 9.0);
            //Console.WriteLine(temperatureF = (temperatureC * 9.0 /59.0) + 32.0);
        }
    }
}

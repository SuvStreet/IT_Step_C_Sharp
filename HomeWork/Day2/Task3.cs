using System;

namespace HomeWork3_Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;

            while (flag == true)
            {

                Console.Write("Введите число в диопозоне от 100 до 999: ");
                System.Int32 digit = Convert.ToInt32(Console.ReadLine());

                if (digit >= 100 && digit <= 999)
                {

                    switch (digit / 100)
                    {
                        case 1: Console.Write("сто");
                            break;
                        case 2: Console.Write("двести");
                            break;
                        case 3: Console.Write("тристо");
                            break;
                        case 4: Console.Write("четыресто");
                            break;
                        case 5: Console.Write("пятьсот");
                            break;
                        case 6: Console.Write("шестьсот");
                            break;
                        case 7: Console.Write("семьсот");
                            break;
                        case 8: Console.Write("восемсот");
                            break;
                        case 9: Console.Write("девятьсот");
                            break;
                    }

                    switch ((digit / 10) % 10)
                    {
                        case 1:
                            switch (digit % 10)
                            {
                                case 0: Console.WriteLine(" десять");
                                    break;
                                case 1: Console.WriteLine(" одиннадцать");
                                    break;
                                case 2: Console.WriteLine(" двенадцать");
                                    break;
                                case 3: Console.WriteLine(" тринадцать");
                                    break;
                                case 4: Console.WriteLine(" четырнадцать");
                                    break;
                                case 5: Console.WriteLine(" пятнадцать");
                                    break;
                                case 6: Console.WriteLine(" шестнадцать");
                                    break;
                                case 7: Console.WriteLine(" семнадцать");
                                    break;
                                case 8: Console.WriteLine(" восемнадцать");
                                    break;
                                case 9: Console.WriteLine(" девятнадцать");
                                    break;
                            }
                            break;
                        case 2: Console.Write(" двадцать");
                            break;
                        case 3: Console.Write(" тридцать");
                            break;
                        case 4: Console.Write(" сорок");
                            break;
                        case 5: Console.Write(" пятьдесят");
                            break;
                        case 6: Console.Write(" шестьдесят");
                            break;
                        case 7: Console.Write(" семдесят");
                            break;
                        case 8: Console.Write(" восемдесят");
                            break;
                        case 9: Console.Write(" девяносто");
                            break;
                    }

                    switch ((digit / 10) % 10)
                    {
                        case 0:
                        case 2:
                        case 3:
                        case 4:
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                        case 9:
                            switch (digit % 10)
                            {
                                case 1: Console.Write(" один");
                                    break;
                                case 2: Console.Write(" два");
                                    break;
                                case 3: Console.Write(" три");
                                    break;
                                case 4: Console.Write(" четыре");
                                    break;
                                case 5: Console.Write(" пять");
                                    break;
                                case 6: Console.Write(" шесть");
                                    break;
                                case 7: Console.Write(" семь");
                                    break;
                                case 8: Console.Write(" восемь");
                                    break;
                                case 9: Console.Write(" девять");
                                    break;
                            }
                            Console.WriteLine();
                            break;
                    }
                }
                else Console.WriteLine("Not found 404!");

                Console.WriteLine("\nЕсли хотите выйти намите Escape, что бы продолжить нажмите любую клавишу...\n");
                ConsoleKeyInfo key = Console.ReadKey();
                Console.Clear();
                if (key.Key == ConsoleKey.Escape)
                {
                    flag = false;
                }
            }
        }
    }
}

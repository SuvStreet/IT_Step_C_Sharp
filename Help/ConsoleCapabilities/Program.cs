using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleCapabilities
{

    class Program
    {
        static void Main(string[] args)
        {
            int origWidth, width = 100;
            int origHeight, height = 25;

            // возвращает (устанавливает) текст заголовка окна консоли. 
            Console.Title = "Эмитирование загрузки";

            for (int i = 0; i <= 100; i++)
            {
                Console.Clear(); // очистка консоли
                Console.WriteLine("Загрузка {0}", i); // форматированный вывод в консоль
                Thread.Sleep(40); // System.Threading подключить namespace,  задать задержку в миллисекундах

                if (i == 0) { Console.ForegroundColor = ConsoleColor.DarkRed; }
                else if (i == 20) { Console.ForegroundColor = ConsoleColor.Red; }
                else if (i == 40) { Console.ForegroundColor = ConsoleColor.DarkMagenta; }
                else if (i == 60) { Console.ForegroundColor = ConsoleColor.Magenta; }
                else if (i == 80) { Console.ForegroundColor = ConsoleColor.Green; }
                else if (i == 99) { Console.ForegroundColor = ConsoleColor.Yellow; }
                else if (i == 100) { Console.ForegroundColor = ConsoleColor.White; }
            }

            Console.WriteLine(); // Вывод пустрой строки

            origWidth = Console.WindowWidth;
            origHeight = Console.WindowHeight;

            Console.WriteLine("Текущая ширина окна {0}, и высота текущего окна {1}.", origWidth, origHeight);

            Console.WindowWidth = width;
            Console.WindowHeight = height;

            int newWidth = Console.WindowWidth;
            int newHeight = Console.WindowHeight;

            // устанавливаем значение высоты и ширины окна консоли
           // Console.SetWindowSize(width, height);
            Console.WriteLine("Новая ширина окна {0}, и высота текущего окна {1}.", newWidth, newHeight);

            // возвращает или устанавливает значение индикатора  видимости  курсора 
            Console.CursorVisible = false;

            Console.WriteLine(); // Вывод пустрой строки

            // Задает константы, которые определяют основной цвет фона консоли
            Console.ForegroundColor = ConsoleColor.Black; // чёрный

            // Задает константы, которые определяют основной цвет текста.
            Console.ForegroundColor = ConsoleColor.Black; // чёрный
            Console.WriteLine("[1] Helloy word!");

            Console.ForegroundColor = ConsoleColor.DarkBlue; // Тёмно-синий
            Console.WriteLine("[2] Helloy word!");

            Console.ForegroundColor = ConsoleColor.DarkGreen; // Тёмно-зеленый 
            Console.WriteLine("[3] Helloy word!");

            Console.ForegroundColor = ConsoleColor.DarkCyan; // Тёмно-бирюзовый (тёмный сине-зелёный)
            Console.WriteLine("[4] Helloy word!");

            Console.ForegroundColor = ConsoleColor.DarkRed; // Тёмно-красный
            Console.WriteLine("[5] Helloy word!");

            Console.ForegroundColor = ConsoleColor.DarkMagenta; // Тёмно-пурпурный (тёмный пурпурно-красный).
            Console.WriteLine("[6] Helloy word!");

            Console.ForegroundColor = ConsoleColor.DarkYellow; // Тёмно-желтый цвет (коричнево-жёлтый).
            Console.WriteLine("[7] Helloy word!");

            Console.ForegroundColor = ConsoleColor.Gray; // Серый
            Console.WriteLine("[8] Helloy word!");

            Console.ForegroundColor = ConsoleColor.DarkGray; // Тёмно-серый
            Console.WriteLine("[9] Helloy word!");

            Console.ForegroundColor = ConsoleColor.Blue; // Синий
            Console.WriteLine("[10] Helloy word!");

            Console.ForegroundColor = ConsoleColor.Green; // Зелёный
            Console.WriteLine("[11] Helloy word!");

            Console.ForegroundColor = ConsoleColor.Cyan; // Бирюзовый (сине-зелёный).
            Console.WriteLine("[12] Helloy word!");

            Console.ForegroundColor = ConsoleColor.Red; // Красный
            Console.WriteLine("[13] Helloy word!");

            Console.ForegroundColor = ConsoleColor.Magenta; // Пурпурный (пурпурно-красный).
            Console.WriteLine("[14] Helloy word!");

            Console.ForegroundColor = ConsoleColor.Yellow; // Жёлтый
            Console.WriteLine("[15] Helloy word!");

            Console.ForegroundColor = ConsoleColor.White; // Белый
            Console.WriteLine("[16] Helloy word!");

            // сбрасывает значение цвета текста и фона 
            Console.ResetColor();

            Console.WriteLine(); // Вывод пустрой строки
            Console.WriteLine("[17] Helloy word!");

            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class ClassWork
    {
        static void Main(string[] args)
        {
            try
            {
                Car car = new Car(Console.ReadLine()); // создание объекта,
                                                       // если имя пустое (пользователь просто нажал Enter),
                                                       // то создаётся исключение и мы поподаем в блок catch
            }
            catch (CarException ex) // обработка пользовательского исключения
            {
                Console.WriteLine(ex.Message); // вывод пользовательского исключения
            }
            catch (Exception ex) // обработка всех исключений
            {
                Console.WriteLine(ex.Message); // вывод поймонного исключения
            }
            Console.ReadLine();
        }
    }
}

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
            catch (Exception ex) // создаём ссылку ex где будет храниться обект исключения
            {
                Console.WriteLine(ex.Message); // обращаемся к свойству исключения где и находится
                                               // наше сообщение исключения
            }
            Console.ReadLine();
        }
    }
}

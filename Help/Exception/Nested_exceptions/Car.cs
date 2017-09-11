using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Car
    {
        private string name; // поле

        public Car(string name) // конструктор
        {
            if (String.IsNullOrEmpty(name)) // пользователь вводит пустую строку
            {
                // общие исключение
                throw new CarException("car is not create", 
                    // вложенное исключение
                    new ArgumentException("name is empty")); // генерация исключения
                                                             // (обращается в Main, где создаю объект)
            }
        }
    }
}

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
                throw new ArgumentException(); // генерация исключения (обращается в Main, где создаю объект)
            }
        }
    }
}

# ExampleStandartAttribute

ExampleStandartAttribute
===

```cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExampleStandartAttribute
{
      
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            //car.ShowInfo();  // Ошибка!
            Console.ReadLine();
        }
    }

    // атрибут Obsolete - задает уведомление о том, что класс
    // устарел и выводит дополнительно сообщение "Класс автомобиль!"
    [Obsolete("Класс автомобиль!")]
    class Car
    {
        // значения атрибута Obsolete - устанавливает ошибки 
        // при исппользовании  метода ShowInfo()
        [Obsolete("Метод класса автомобиль!", true)]
        public void ShowInfo()
        {
            Console.WriteLine("Метод класса Car");
        }
    }
}
```

![](https://pp.userapi.com/c840228/v840228232/21436/pX1Y5GqzspQ.jpg)

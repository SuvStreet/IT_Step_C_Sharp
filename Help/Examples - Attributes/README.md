# Example 1.1 Standart Attribute (Пример стандартного атрибута)

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

# Example 1.2 Standart Attribute (Пример стандартного атрибута)

```cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// подключаем пространство имен
using FriendAssemblies;

namespace Example1._1StandartAttribute
{
    class Program
    {
        static void Main(string[] args)
        {
            // Работа с дружественными сборками! 
            ShopCars shop = new ShopCars();

            Console.WriteLine("В магазине всего авто: " + shop.CountCars);

            // создание объекта internal CarInfo
            CarInfo carInfo = new CarInfo()
            {
                Name="BMW"
            };

            // вызов internal метода класса ShopCars
            shop.AddCar(carInfo);

            Console.WriteLine("В магазине всего авто: " + shop.CountCars);

            Console.ReadKey();

        }
    }
}
```

![](https://pp.userapi.com/c837333/v837333232/5aee3/_2FiDEO-v5M.jpg)

# Example 1.3 Standart Attribute (Пример стандартного атрибута)

```cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1._3StandartAttribute
{
    public class CarInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

/ *** /

using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace Example1._3StandartAttribute
{
    static class Loger
    {
        // аттрибут CallerMemberName используется только в методах 
        // с необязательными параметрами
        public static void LogWrite([CallerMemberName] string MemberName="")
        {
            File.AppendAllText("log.txt", MemberName);
        }
    }
}

/ *** /

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1._3StandartAttribute
{
    public class ShopCars
    {
        List<CarInfo> lstCars;

        public ShopCars()
        {
            lstCars = new List<CarInfo>();
        }

        public int CountCars
        {
            get { return lstCars.Count; }
        }

        public void AddCar(CarInfo car)  // метод тоже internal т.к. работает с internal CarInfo
        {                                //  public нельзя т.к. inconsistent accessibility  
            lstCars.Add(car);
            Loger.LogWrite();
        }

        public void DeleteCar(CarInfo car)  // метод тоже internal т.к. работает с internal CarInfo
        {                                   //  public нельзя т.к. inconsistent accessibility  
            lstCars.Remove(car);
            Loger.LogWrite();
        }
    }
}

/ *** /

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1._3StandartAttribute
{
    class Program
    {
        static void Main(string[] args)
        {
            ShopCars shop = new ShopCars();

            Console.WriteLine("В магазине всего авто: " + shop.CountCars);

            CarInfo carInfo1 = new CarInfo() { Name = "BMW"};
            shop.AddCar(carInfo1);
            CarInfo carInfo2 = new CarInfo() { Name = "Ford" };
            shop.AddCar(carInfo2);   
            Console.WriteLine("В магазине всего авто: " + shop.CountCars);
            
            
            shop.DeleteCar(carInfo2);
            Console.WriteLine("В магазине всего авто: " + shop.CountCars);
            Console.ReadKey();
        }
    }
}
```

![](https://pp.userapi.com/c840329/v840329232/12b50/f0kQm1KPg1U.jpg)

# Example 2.1 Simple Attribute (Пример простого атрибута)

```cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example4
{
    class Program
    {
        static void Main(string[] args)
        {
            // получение атрибута их типа!
            InfoAboutClass.GetAttribute(typeof(Car));
          
            Console.ReadKey();
        }
    }

    // Создание пользовательского атрибута!
    [AttributeUsage (AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple=false, Inherited=true)]  // указывает, что атрибут буде примен только к классу
    class InfoAboutAttribute : Attribute  // наследуемся от класса Attribute
    {
        public string Desc; 
    }

    [InfoAbout(Desc="Класс автомобиль")]  // применение атрибута
    class Car
    {
       // тело класса
    }

    class InfoAboutClass
    {
        public static void GetAttribute(Type t)
        {   
            // получение сведений об атрибуте 
            InfoAboutAttribute att = (InfoAboutAttribute)Attribute.GetCustomAttribute(t, typeof(InfoAboutAttribute));
            Console.WriteLine("{0}", att.Desc);
        }
    }
}
```

![](https://pp.userapi.com/c837738/v837738232/60393/aGQV5F_OIxc.jpg)

# Example 2.2 Attribute (Пример атрибута)

```cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleAtributs
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleHuman Petr = new SimpleHuman("Петр", "Иванов");
            Student Ivan = new Student("Иван", "Немиров");

            HumanPrinter HP = new HumanPrinter();
            HP.Show(Petr);   // Объект Petr выводится без
            // трансформации текста

            HP.Show(Ivan);   // Объект Ivan выводится с
            // трансформацией текста

            Console.ReadKey();
        }
    }


    interface IHuman
    {
        string getFName { get; } // Получить Фамилию Человека
        string getSName { get; } // Получить Имя Человека
    }

    //  Пользовательский атрибут трансформации текста в верхний/нижний регистр
    public sealed class TextTransformAttribute : System.Attribute
    {
        public bool isUpperCase; // true - в верхний регистр,
        // false - в нижний
    }

    class SimpleHuman : IHuman
    {
        string FName, SName;
        public SimpleHuman(string FNm, string SNm)
        {
            FName = FNm;
            SName = SNm;
        }
        public string getFName
        {
            get { return FName; }
        }
        public string getSName
        {
            get { return SName; }
        }
    }

    //   Класс "Студент" также хранит Фамилию и Имя
    //   с помощью атрибута TextTransform формируем метаданные
    //   с информацией о том, что Фамилия и Имя должны переводиться
    //   в верхний регистр.
    [TextTransform(isUpperCase = true)]
    class Student : IHuman
    {
        string FName, SName;
        public Student(string FNm, string SNm)
        {
            FName = FNm;
            SName = SNm;
        }
        public string getFName
        {
            get { return FName; }
        }
        public string getSName
        {
            get { return SName; }
        }
    }

    class HumanPrinter
    {
        public void Show(IHuman H)
        {
            string firstName = H.getFName;
            string surrName = H.getSName;
            // ----- Проверка, на атрибут TextTransform ---------------------
            Type T = H.GetType();
            TextTransformAttribute[] TTA = (TextTransformAttribute[])T.GetCustomAttributes(typeof(TextTransformAttribute), false);

            if (TTA.Length != 0)
            {
                // ----- атрибут TextTransform обнаружен, переводим в нужный регистр ----
                firstName = (TTA[0].isUpperCase) ? firstName.ToUpper() : firstName.ToLower();
                surrName = (TTA[0].isUpperCase) ? surrName.ToUpper() : surrName.ToLower();
            }

            // ----- Вывод на экран -----------------------------------------
            Console.WriteLine("----------");
            Console.WriteLine("Фамилия : {0}", firstName);
            Console.WriteLine("Имя : {0}", surrName);
        }
    }
}
```

![](https://pp.userapi.com/c841538/v841538232/29190/qh7niVX6Y9c.jpg)

# Friend Assemblies

```cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// указываем для аттрибута InternalsVisibleTo
using System.Runtime.CompilerServices;

// аттрибут будет позволять сборке  Example1.1StandartAttribute
// получать доступ к internal типам и методам текущей сборки

[assembly: InternalsVisibleTo("Example1.1StandartAttribute")]

namespace FriendAssemblies
{
    internal sealed class CarInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

/ *** /

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendAssemblies
{
    public class ShopCars
    {
        List<CarInfo> lstCars;

        public ShopCars()
        {
            lstCars = new List<CarInfo>();
        }

        public int CountCars
        {
            get { return lstCars.Count; }
        }

        internal void AddCar(CarInfo car)  // метод тоже internal т.к. работает с internal CarInfo
        {                                  // public нельзя т.к. inconsistent accessibility  
            lstCars.Add(car);
        }
    }
}
```

![](https://pp.userapi.com/c841135/v841135232/27599/9NAz9rf2Eqw.jpg)

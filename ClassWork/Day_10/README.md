> **Материал подготовлен преподавателем Комаров Иван Николаевич по курсу "Платформа Microsoft.NET и язык программирования С#". Учебное заведение "Компьютерная Академия Шаг".**

Наследование
===

**`Наследование`** – механизм ООП, позволяющий описать новый класс на основе уже существующего (базового), при этом данные и функциональность базового класса заимствуются новым классом.

**Главная задача наследования - обеспечить повторное использование кода.**

Существует два основных вида наследования:
* классическое наследование;
* включение-делегирование;

**`Наследуются:`**
1. **поля**
2. **методы**
3. **свойства**
4. **операторы**
5. **индексаторы**
6. **события**

НЕКОТОРЫЕ ОСОБЕННОСТИ НАСЛЕДОВАНИЯ
---

* Объект производного класса **`содержит все члены базового класса!!!`**
* Производный класс имеет прямой доступ ко всем **`public`** полям, методам и свойствам базового класса
* Элементы базового класса с модификатором **`private`** не доступны в производном классе.
* Конструкторы базового класса **`не переносятся`** в производный класс.
* Наследование **`от двух и более классов`** в C# запрещено.
* Ни один класс **`не может быть базовым`** (ни прямо, ни косвенно) для самого себя.

**`Чтобы указать, что один класс является наследником другого, используется следующий синтаксис:`**

```cs
class имя_производного_класса: имя_базового_класса
{
  // тело производного класса
}
```

![](https://pp.userapi.com/c639729/v639729120/4a8f9/PJrEDhKwTxg.jpg)

```cs
// класс транспортное средство
class Vehicle
{
  public string Type {get; set;}  // тип транспортного средства
  public string Name {get; set;}  // название транспортного средства
  public double Speed {get; set;} // скорость транспортного средства
  public string GetInfo()
  {
    return String.Format("{0} {1}, скорость: {2}",Type, Name, Speed );
  }
}
```

```cs
// класс грузовик
class Truck : Vehicle // наследование
{
  public double Load {get; set;} // грузоподъемность
}
```

```cs
static void Main(string[] args)
{
  Vehicle vehicle = new Vehicle();
  vehicle.Type = "Транспортное средство";
  vehicle.Name = "Обобщенное транспортное средство";
  vehicle.Speed = 150;
  // vehicle.Load = 2.8; // ОШИБКА
  Console.WriteLine(vehicle.GetInfo());

  Truck truck = new Truck();
  truck.Type = "Грузовик "; // наследование открытых полей
  truck.Name = «МАЗ";
  truck.Speed = 90;
  truck.Load = 3.8;
  Console.WriteLine(truck.GetInfo()); // наследование открытых методов
}
```

Вызов конструкторов базового класса
---

**`Производный класс`** может вызывать **`конструктор`**, определенный в его **`базовом классе`**, используя **`расширенную форму объявления конструктора`** производного класса и ключевое слово **`base`**.

Формат расширенного объявления таков:

```cs
конструктор_производного_класса (список_параметров): base (список_аргументов)
{
  // тело конструктора
}
```

С помощью элемента **`список_аргументов`** задаются аргументы, необходимые конструктору в базовом классе.

```cs
public class SomeType
{
}
// конструктор по умолчанию
public class SomeType
{
  public SomeType() : base()
  {
  }
}
```

Порядок вызова конструкторов
---

* в иерархии классов конструкторы вызываются по порядку выведения классов: **`от базового к производному`**;
* если в иерархии классов конструктору базового класса **`требуются параметры`**, то **все производные классы** должны предоставлять **`эти параметры вверх по иерархии`**, независимо от того, требуются они самому производному классу или нет.

Особенности использования конструкторов при наследовании
---

```cs
class Vehicle
{
  public string Type {get; set;}
  public string Name {get; set;}
  public double Speed {get; set;}
  public string GetInfo() { return String.Format("{0} {1},: {2}", Type, Name, Speed ); }

  // конструктор базового класса (конструкторы не наследуются)
  public Vehicle(string T, string N, double V)
  {
    this.Type = T; this.Name = N; this.Speed = V;
  }
}
```

```cs
class Truck : Vehicle
{
 public double Load {get; set;}
 // Конструктор
 public Truck(string T, string N, double V, double Load)
 :base(T,N,V)
 {
 this.Load = Load;
 } 
```

Доступ к членам базового класса
---

Наследование класса не отменяет ограничения, связанные с **`закрытым доступом (private)`**.

Производный класс включает `все члены базового класса`, но он не может получить **`прямой доступ`** к закрытым членам.

Использование защищённого доступа
---

Защищенный член создается с помощью модификатора доступа **`protected`**.

Когда **`защищенный`** член наследуется, то он становится **доступным для производного класса**.

Спецификаторы доступа при наследовании
---

```cs
class Vehicle
{
  string Type;
  string Name;
  protected double Speed ; // (модификатор доступа защищенный)
  public string GetInfo() { return String.Format("{0} {1}, : {2}", Type, Name, Speed ); }
  public Vehicle(string T, string N, double V) { this.TypeV = T; this.Name = N; this.Speed = V; }
}
```

```cs
class Truck : Vehicle
{
  double Load;
  public Truck(string T, string N, double V, double Load): base(T, N, V) { this.Load = Load; }
  public void UpdateTruck()
  {
  // truck.Type = "Большой грузовик"; // ОШИБКА т.к. (private)
  Speed = 100; // ОШИБКИ НЕТ!
  }
}
```

Сокрытие имен при наследовании
---

```cs
class Vehicle
{
  protected string TypeV;
  protected string Name;
  protected double Speed;
  public Vehicle(string T, string N, double V) { this.TypeV = T; this.Name = N; this.Speed = V; }
  public string GetInfo() { return String.Format("{0} {1}, : {2}", TypeV, Name, Speed); }
}
```

```cs
class Truck : Vehicle
{
  double Load;
  public Truck(string T, string N, double V, double Load): base(T,N,V) { this.Load = Load; }
  
  // метод с одинаковым именем, как в базовом классе для исключения предупреждения о сокрытии имен используется new
  new public string GetInfo()
  {
    // вызов варианта метода GetInfo() из базового класса с использованием ключевого слова base
    return base.GetInfo() + " грузоподъемность: " + Load;
  }
}
```

```cs
// Создать диаграмму классов: На проекте View->View Class Diagramm
```

![](https://pp.userapi.com/c841539/v841539120/270fd/YFE6P_BB11k.jpg)

Создание специальных исключений
---

Для получения специального исключения необходимо создать новый класс, унаследованный от класса **`System.Exception`** или **`System.ApplicationException`**. (по соглашению, имена всех классов исключений оканчиваются суффиксом Exception).

* наследоваться от **`ApplicationException`**;
* сопровождаться атрибутом **`[System.Serializable]`**;
* иметь **`конструктор по умолчанию`**;
* иметь конструктор, который устанавливает значение унаследованного **`свойства Message`**;
* иметь конструктор для обработки **`"вложенных исключений"`**;
* иметь конструктор для обработки **`сериализации типа`**.

```cs
// атрибут для сериализации (далее в курсе)
[Serializable]
public class TruckException : Exception
{
  // конструкторы
  public TruckException()
  { }
  
  // конструкторы для инициализации св-ва Message
  public TruckException(string message) : base(message)
  { }
  
  public TruckException(string message, Exception ex) : base(message)
  { }
  
  // Конструктор для обработки сериализации типа
  protected TruckException(SerializationInfo info, StreamingContext contex): base(info, contex)
  { }
}
```

```cs
class Truck
{
  private double load;          // грузоподъемность
  private double loadMax=5000;  // макс. грузоподъемность

// В свойстве генерируется исключение TruckException
  public double Load
  {
    get
    {
      return Load;
    }
    set
    {
      load += value;
      if (load >= loadMax) throw new TruckException("Превышена грузоподъемность");
    }
  }
}
```

```cs
try
{
  Truck truck = new Truck();
  truck.Load = 3000;
  truck.Load = 2500;
}
catch (TruckException ex)
{
  Console.WriteLine(ex.Message);
}
```

Использование ссылок на базовый класс.
---

21




















***

[**-->     HomeWork10     <--**]()

**19.09.2017**

[**<-- Свойства. Индексаторы**](https://github.com/SuvStreet/IT_Step_C_Sharp/tree/master/ClassWork/Day9#Свойства-Индексаторы) `=/=` [** -->**]()

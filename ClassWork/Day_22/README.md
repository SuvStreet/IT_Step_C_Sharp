> **Материал подготовлен преподавателем Комаров Иван Николаевич по курсу "Платформа Microsoft.NET и язык программирования С#". Учебное заведение "Компьютерная Академия Шаг".**

Атрибуты
===

![](https://pp.userapi.com/c639527/v639527161/6039e/dRypfqoTXb8.jpg)

**`Атрибуты`** представляют собой аннотации программного кода, которые могут применяться к заданному типу (классу, интерфейсу, структуре и т.д.), а так же к членам типа (полям, методам, свойствам).

**`Основное назначение`** возможность определять **дополнительную функциональность (добавлять специальную информацию) к элементам кода через метаданные.**

Информация об этих расширениях метаданных запрашивается **во время выполнения** с целью **динамического** изменения хода выполнения программы.

Атрибуты используются для служб, которые глубоко интегрированы в систему типов, и не требует специальных ключевых слов или конструкций в языке С#.

**Существует два типа атрибутов:**
* **`Предопределенные`** атрибуты (в составе .NET),
* **`Пользовательские`** атрибуты, создаваемые пользователем для добавления в код дополнительных сведений.

Атрибуты в платформе .NET являются **`типами (классами)`**, расширяющими абстрактный базовый класс **`System.Attribute`**.

* Наследование от класса **`System.Attribute`** обусловлено соответствием общеязыковой спецификации CLS.
* Наследование может быть прямое или косвенное

Пример предопределенных атрибутов
---

* **`[Obsolete]`** атрибут Obsolete позволяет пометить элемент программы как устаревший.
* **`[Seriаlizable]`** информирует механизмы сериализации о том, что поля доступны для сериализации и десериализации.
* **`[DllImport]`** информирует CLR о том, что метод реализован в неуправляемом коде указанной DLL-библиотеки.
* **`[NonSerialized]`** позволяет указать, что данное поле в классе или структуре не должно сохраняться в процессе сериализации
* **`[AssemblyVersion]`** при применении к сборке задает версию сборки.
* **`[Flags]`** указывает, что перечисление будет представлять набор битовых флагов.

Пример использования предопределѐнного атрибута
---

```cs
public sealed class ObsoleteAttribute : Attribute
{
  public ObsoleteAttribute();
  public ObsoleteAttribute(string message);
  public ObsoleteAttribute(string message, bool error);
  public bool IsError { get; }
  public string Message { get; }
}


// атрибут Obsolete - задает уведомление о том, что класс
// устарел и выводит дополнительно сообщение "Класс автомобиль!"
[Obsolete("Класс автомобиль!")]
class Car
{
  // значения атрибута Obsolete - устанавливает ошибки
  // при использовании метода ShowInfo()
  [Obsolete("Метод класса автомобиль!", true)]
  public void ShowInfo()
  {
    Console.WriteLine("Метод класса Car");
  }
}
```

![](https://pp.userapi.com/c840428/v840428161/15789/o2BtOe7DmYQ.jpg)

Параметры атрибутов
---

Многие атрибуты имеют параметры:
* позиционные
* именованные

```cs
[DllImport("user32.dll", ExactSpelling = false)]
```

* **`Позиционные параметры:`** аргументы конструктора класса атрибута (всегда указываются перед именованными)
* **`Именованные параметры:`** все открытые нестатические поля и свойства класса атрибута, доступные для записи

```cs
[DllImport("user32.dll")]
[DllImport("user32.dll", SetLastError=false, ExactSpelling=false)]
[DllImport("user32.dll", ExactSpelling=false, SetLastError=false)]
```

Целевые объекты атрибутов
---

Неявно целью атрибута является элемент кода, который находится непосредственно за атрибутом, но атрибуты можно присоединять и к сборке.

Атрибут   | Свойства
----------|--------------------
assembly  | Целая сборка
field     | Поле в классе или в структуре
event     | События
method    | Метод или метод доступа к свойствам get или set
param     | Параметры методов или параметры методов доступа к свойствам set
property  | Свойство
return    | Возвращаемое значение метода, индексатор свойств или метод доступа к свойствам get
type      | Структура, класс, интерфейс, перечисление или делегат

```cs
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: AssemblyCopyright("Copyright © 2015")]
```

Указание атрибутов
---

**Идентичные указания атрибутов:**

```cs
[Serializable, Obsolete, CLSCompliant(false)]
public class Car { }

[Serializable][Obsolete][CLSCompliant(false)]
public class Car { }

[Serializable, Obsolete]
[CLSCompliant(false)]
public class Car { } 
```

Правила создания пользовательского атрибута
---

1. Имя атрибута должно содержать суффикс `Attribute`.
2. Класс-атрибут обязан наследоваться от системного класса `System.Attribute`
3. Класс-атрибут может быть отмечен атрибутом `[AttributeUsageAttribute]`

Пример объявление пользовательского атрибута
---

```cs
class InfoAboutAttribute : Attribute
{
  // тело атрибута (класса)
  public string Desc { get; set; }
}

[InfoAbout(Desc = "Класс автомобиль")]
class Car
{
  // тело класса
}
```

Рекомендации по созданию пользовательского атрибута
---

* Атрибут следует рассматривать как логический контейнер состояния - **`этот класс должен быть крайне простым`**.
* Атрибут должен содержать всего **`один открытый конструктор`**, принимающий обязательную (или позиционную) информацию о состоянии атрибута.
* Атрибут может содержать **`открытые поля/свойства`**, принимающие дополнительную (или именованную) информацию о состоянии атрибута.
* В классе **`не должно быть открытых методов, событий или других членов`**.

**`Важно!`** Лучше использовать в атрибуте свойства, так как они обеспечивают большую гибкость в случаях, когда требуется внести изменения в реализацию класса атрибутов.

Системный атрибут AttributeUsage
---

Используется для создания пользовательских атрибутов.

Позиционные параметры:
* **validOn** – имеет тип `AttributeTargets`, указывает, к чему можно применять данный атрибут.

Именованные параметры:
* **AllowMultiple** – имеет тип `bool`, разрешает или запрещает множественное применение атрибута (по умолчанию - `false`) *(возможно ли для одного элемента программы задать более одного экземпляра указанного атрибута)*
* **Inherited** – имеет тип `bool`, разрешает или запрещает наследование атрибута в производных классах (по умолчанию - `true`).

```cs
public enum AttributeTargets
{
  All, Assembly, Class, Constructor,
    Delegate, Enum, Event, Field,
      GenericParameter, Interface, Method,
        Parameter, Property, ReturnValue, Struct
}
```

Варианты применения атрибута AttributeUsage
---

```cs
[AttributeUsage (AttributeTargets.Class)]
// указывает, что атрибут буде применен только к классу
class InfoAboutAttribute : Attribute
{ public string Desc; }


[AttributeUsage (AttributeTargets.Class| AttributeTargets.Interface)]
class InfoAboutAttribute : Attribute
{ public string Desc; }

[AttributeUsage (AttributeTargets.Class | AttributeTargets.Interface, Inherited = true)]
class InfoAboutAttribute : Attribute
{ public string Desc; }

[AttributeUsage (AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false, Inherited = true)]
class InfoAboutAttribute : Attribute
{ public string Desc; }
```

Пример передачи параметров атрибуту
---

```cs
[System.AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Struct) ] 
public class AuthorAttribute : System.Attribute
{
  private string name;
  public double version {get; set;};
  public Author(string name)
  {
    this.name = name; version = 1.0;
  }
}

[Author(“Г. Шилдт", version = 4.0)]
class SampleClass
{
  //...
}
```

Выявление настраиваемых атрибутов
---

**`Важно!`** После определения собственных классов атрибутов нужно также **`написать код, проверяющий, существует ли экземпляр класса атрибута`** (для указанных элементов), и в зависимости от результата изменять порядок выполнения программы.

```cs
InfoAboutAttribute att = (InfoAboutAttribute)Attribute.GetCustomAttribute(t, typeof(InfoAboutAttribute));
Console.WriteLine("{0}", att.Desc);
```

Пример объявление пользовательского атрибута
---

```cs
class InfoAboutAttribute : Attribute
{
  // тело атрибута (класса)
  public string Desc;
}

[InfoAbout(Desc = "Класс автомобиль")]
class Car
{
  // тело класса
}
```

```cs
class InfoAboutClass
{
  public static void GetAttribute(Type t)
  {
    // получение сведений об атрибуте
    InfoAboutAttribute att = (InfoAboutAttribute)Attribute.GetCustomAttribute (t, typeof(InfoAboutAttribute));

    Console.WriteLine("{0}", att.Desc); // Вывод переданной информации
  }
}


class Program
{
  static void Main(string[] args)
  {
    // получение атрибута их типа!
    InfoAboutClass.GetAttribute(typeof(Car));
    Console.ReadKey();
  }
}
```

Дополнительно...
---

В версии С# 5.0, **необязательные параметры** можно помечать с помощью одного из трех атрибутов о вызывающем компоненте, которые инструктируют компилятор о необходимости передачи информации, полученной из исходного кода вызывающего компонента, в стандартное значение параметра:

* `[CallerMemberName]` применяет имя члена вызывающего компонента;
* `[CallerFilePath]` применяет путь к файлу исходного кода вызывающего компонента;
* `[CallerLineNumber]` применяет номер строки в файле исходного кода вызывающеrо компонента;

```cs
public static void LogWrite([CallerMemberName] string MemberName = "")
{
  File.AppendAllText("log.txt", MemberName);
}
```

Сериализация
===

![](https://pp.userapi.com/c837222/v837222650/55c96/cZLqdipZHaQ.jpg)

***Понятие сериализации объектов***

**`Сериализация`** представляет собой процесс преобразования находящегося в памяти объекта (графа объектов - набора объектов, ссылающихся друг на друга) в поток байтов (ХМL-узлов) для последующего его воссоздания.

* Сохраненная последовательность байт содержит всю необходимую информацию для воссоздания объекта.
* Обратный процесс называется **`десериализацией`**.

![](https://pp.userapi.com/c840524/v840524650/12122/IHi7Jcjif2s.jpg)

**Объект сериализуется в поток, который переносит не только данные, но и сведения о типе объекта**

Превращение объекта в сериализуемый
---

Для сериализации объекта необходимо класс отметить атрибутом **`[Serializable]`**.

**Для сериализации объектов можно использовать следующие классы:**

* **BinaryFormatter (двоичный файл);**
* **SoapFormatter (файл формата SOAP);**
* **XmlSerializer (XML-файл);**

**System.Runtime.Serialization**

**System.xrnl.Serialization**

Класс BinaryFormatter
---

Сериализует состояние объекта в поток, используя компактный *двоичный формат* (двоичная кодировка).

Этот тип определен в пространстве имен **`System.Runtime.Serialization.Formatters.Binary`**

* **`BinaryFormatter`** представляет собой наиболее эффективный способ сериализации.
* Обеспечивает совместимость только между версиями.NET Framework.

**`Ограничение`**: сериализация и десериализация должны выполняться только.NET приложениями

Пример сериализации объекта
---

**`Создание класса сериализуемого объекта`**

```cs
using System;
using System.Runtime.Serialization;

[Serializable]
class Book
{
  int id;
  string name;
  double price;
  public Book(int ID, string Name, double Price)
  {
    id = ID; name = Name; price = Price;
  }
  public override string ToString()
  {
    return string.Format("{0}.{1},{2}", id, name, price);
  }
}

/ *** /

using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

class Program
{
  public static void Main()
  {
    Book book=new Book(1, "Война и мир", 2.6);
    using (FileStream file=new FileStream("file.txt", FileMode.Create))
    {
      BinaryFormatter binFormat = new BinaryFormatter();
      binFormat.Serialize(file,book);
    }
    Book openBook; // десериализация объекта
    using (FileStream file=new FileStream("file.txt", FileMode.Open))
    {
      BinaryFormatter binFormat = new BinaryFormatter();
      openBook = (Book)binFormat.Deserialize(file);
    }
    Console.WriteLine(openBook);
    Console.ReadKey(true);
  }
}
```

![](https://pp.userapi.com/c837324/v837324650/5506b/ey5Jf5oQZi0.jpg)

![](https://pp.userapi.com/c837228/v837228650/54323/zsrlzg0M_B4.jpg)

**`ВАЖНО!`** В С# внутри типов, помеченных атрибутом [SerializaЬle], не стоит определять автоматически реализуемые свойства. Так как имена полей, генерируемые компилятором, **`могут меняться после каждой следующей компиляции`**, что сделает невозможной десериализацию экземпляров типа.

**`Создание класса сериализуемого объекта с применением атрибута [NonSerialized]`**

```cs
[Serializable]
class Book
{
  public int id { get; set; }
  public string name { get; set; }
  [NonSerialized]// определение несериализуемого поля
  public double price{ get; set; }
  public Book(int ID, string Name, double Price)
  { id = ID; name = Name; price = Price; }
  public override string ToString()
  {
    return string.Format("{0}.{1},{2}", id, name, price);
  }
}
```

![](https://pp.userapi.com/c837420/v837420650/57feb/QVuc7NIl8hg.jpg)

```cs
[Serializable]
class Book
{
  public int id { get; set; }
  public string name{ get; set; }
  [NonSerialized] // определение несериализуемого поля
  public double price { get; set; }
  public Book(int ID, string Name, double Price)
  { id = ID; name = Name; price = Price; }
  public override string ToString()
  { return string.Format("{0}. {1},{2}", id, name, price); }
  [OnDeserialized] // определяются атрибутом [OnDeserialized]
  private void OnDeseria1ized(StreamingContext context)
  {
    // Инициализация после десериализации
    price = 5000;
  }
  [OnDeserializing]
  private void OnDeserializing(StreamingContext context)
  {
    // Присвоение полям значений в новой версии типа
  }
  [OnSerializing]
  private void OnSerializing(StreamingContext context)
  {
    // Модификация состояния перед сериализации
  }
}
```

![](https://pp.userapi.com/c837429/v837429650/5d38c/bneZsYA5NpY.jpg)

```cs
public static void Main()
{
  List <Book> books=new List<Book>()
  {
    new Book(1, "Война и мир", 2.6),
    new Book(2, "Отцы и дети", 5.1),
    new Book(3, "Анна Каренина", 7.3)
  };

  // сериализация коллекции объектов
  using (FileStream file=new FileStream("file.txt", FileMode.Create))
  {
    BinaryFormatter binFormat = new BinaryFormatter();
    binFormat.Serialize(file, books);
  }
  
  // десериализация коллекции объектов
  List <Book> newbooks;
  using (FileStream file=new FileStream("file.txt", FileMode.Open))
  {
    BinaryFormatter binFormat = new BinaryFormatter();
    newbooks = (List<Book>)binFormat.Deserialize(file);
  }

  foreach(Book book in newbooks)
    Console.WriteLine(book);
  Console.ReadKey(true);
}

/ *** /

static void Main(string[] args)
{
  Book Book = new Book(1,"Троелсен C# 4.5",2500);
  Book newBook = (Book)DeepClone(Book);
  Console.WriteLine(Book); Console.WriteLine(newBook);

  Console.WriteLine(new string('-',25));
  newBook.Price = 3000;
  Console.WriteLine(Book);
  Console.WriteLine(newBook);
}

private static Object DeepClone(Object original)
{
  // Создание временного потока в памяти
  using (MemoryStream stream = new MemoryStream())
  {
    // Создания объекта для сериализации
    BinaryFormatter formatter = new BinaryFormatter ();
    
    // Сериализация объекта в поток в памяти
    formatter.Serialize(stream,original);
    
    // Возвращение к началу потока в памяти
    stream.Position = 0;
    
    // Десериализация в новый объект
    return formatter.Deserialize(stream);
  }
}
```

![](https://pp.userapi.com/c837429/v837429650/5d393/rv6ZZISeJgA.jpg)

Сериализация в XML-файл
---

* Подходит для сериализации открытых типов (классов) и членов типов (полей, свойств, методов…).
* Позволяет сериализовать только отдельные объекты.
* Для выполнения XML сериализации не обязательно использовать атрибут **[Serializable]**.

```cs
using System.Xml.Serialization;
```

**Для того, чтобы сериализовать объект в `формате XML` необходимо выполнить следующие действия:**

1. Объявить класс как **открытый**.
2. Объявить все члены класса, которые необходимо сериализовать, как **открытые**.
3. Создать конструктор **не принимающий параметров**.

```cs
public class Book // public
{
  public int id; // открытое поля сериализуются
  public string name; // открытое поля сериализуются
  private double price; // закрытые поля не сериализуются
  public int Pages { get; set; }

  // Обязательный конструктор!
  public Book()
  {

  }
  
  public Book(int ID, string Name, int pages, double Price)
  { id = ID; name = Name; price = Price; Pages = pages; }
  public override string ToString()
  {
    return string.Format("{0}. {1}, {2} стр. {3}", id, name,Pages, price); }
}

/ *** /

using System.Xml.Serialization;

// коллекция для сериализации
List<Book> books = new List<Book>()
{
  new Book(1, "Война и мир", 1500, 2.6),
  new Book(2, "Отцы и дети", 800, 5.1),
  new Book(3, "Анна Каренина",860, 7.3)
};

List<Book> newBooks;
using (FileStream file = new FileStream("file.xml", FileMode.Create))
{
  XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Book>));
  xmlFormat.Serialize(file, books); // сериализация
}

// десериализация объекта
using (FileStream file = new FileStream("file.xml", FileMode.Open))
{
  XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Book>));
  newBooks = (List<Book>)xmlFormat.Deserialize(file);
}

// вывод на экран newBook - десериализованного объекта
foreach (Book book in newBooks) // вывод на экран коллекции
  Console.WriteLine(book.ToString());
```

![](https://pp.userapi.com/c841427/v841427650/27355/PHzWgP6Zfv4.jpg)

```cs
public class Book
{
  // переименовываем и делаем XML атрибутом.
  [XmlAttribute("Number")]
  public int Num { get; set; }
  
  //XML элемент.
  [XmlElement("Title")]
  public string Name { get; set; }
  
  // Исключаем свойство из процесса сериализации/десериализации.
  [XmlIgnore]
  public int Pages { get; set; }
  public double Price { get; set; }

  // Обязательный конструктор!
  public Book() { }

  public Book(int n, string name, int pages, double price)
  { Num = n; Name = name; Price = price; Pages = Pages; }
  public override string ToString()
  { return string.Format("{0}. {1}, {2} стр. {3}", Num, Name, Pages, Price); }
}
```

![](https://pp.userapi.com/c639723/v639723650/4d035/aP3H4a0gHKQ.jpg)

Сериализация в JSON
---

```CS
List<Book> books= new List<Book>
{
  new Book{id=1, name="Война и мир", price=25000},
  new Book{id=2, name="Отцы и дети", price=18000}
};

var jSerialize = new JavaScriptSerializer();
string json = jSerialize.Serialize(books);

Console.WriteLine(json);
Console.WriteLine(new string('-', 20));

List<Book> Books = jSerialize.Deserialize<List<Book>>(json);
foreach (Book book in Books)
   Console.WriteLine(book);

public class Book
{
  public int id; public string name; public double price;
  public Book() { }
  
  public Book(int ID, string Name, double Price)
  { id = ID; name = Name; price = Price; }
  
  public override string ToString()
  { return string.Format("{0}. {1},{2}", id, name, price); }
}
```

![](https://pp.userapi.com/c621701/v621701650/26e5e/81osYsqAepI.jpg)

**`[{"id":1,"name":"Война и мир","price":25000},{"id":2,"name":"Отцы и дети","price":18000}]`**

***

[**-->     HomeWork     <--**]()

**10.10.2017**

[**<-- **]() `=/=` [** -->**]()


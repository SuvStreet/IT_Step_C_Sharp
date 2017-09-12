> **Материал подготовлен преподавателем Комаров Иван Николаевич по курсу "Платформа Microsoft.NET и язык программирования С#". Учебное заведение "Компьютерная Академия Шаг".**

Исключения (Exceptions)
===

![](https://pp.userapi.com/c836122/v836122383/62b3d/IiQOBNNqSvU.jpg)

**`Исключительная  ситуация  (исключение)` — это  ошибка,  которая  возникает  во время выполнения программы.**

Исключением называется ситуация, когда член класса не в состоянии решить возложенную на  него задачу.

**Особенности обработки исключительных ситуаций на C#**

* В С# исключения представляются **`классами`**.  
* Все  классы  исключений  являются  потомками  класса исключений  **`Exception`**,  который  является  частью пространства имен **`System`**.

Основы обработки исключений
---

>  **Формат записи try/catch-блоков обработки исключений:**

```cs
try  
{
        //  Блок кода, в котором может  
        //  возникнуть исключение 
}
catch (тип исключения)
{
        // Обработчик исключения 
}
```

**Ловим исключение с помощью try/catch:**

```cs
Console.WriteLine("Простое исключение"); 
 
try   
// Блок кода, где может произойти  
// исключительная ситуация 
{ 
 int a = Int32.Parse(Console.ReadLine());       
 int b = Convert.ToInt32(Console.ReadLine()); 
 Console.WriteLine("Сумма чисел равна " + (a + b)); 
} 
catch  
{ 
  // Блок кода, который должен обработать  
  // исключительную ситуацию 
  Console.WriteLine("Проверьте тип введенных данных!"); 
} 
```

**Ловим исключение с помощью TryParse:**

```cs
Console.Write(“Использование TryParse()"); 
 
int a; 
if (!Int32.TryParse(Console.ReadLine(), out a))  
// сокращенная запись  
   { 
     Console.Write("тип введенных данных!"); 
      return; 
   } 
 
int b; 
Int32.TryParse(Console.ReadLine(),out b); 
Console.WriteLine(a+b);
```

Свойства класса System.Exception 
---

Название свойства                   |  Описание
------------------------------------|----------------------------------
**`string Message`**                | Содержит текст сообщения с указанием причины возникновения исключения 
**`string Source`**                 | Содержит имя сборки, сгенерировавшей исключение. 
**`string StackTrace`**             | Содержит имена и сигнатуры методов, вызов которых привел к возникновению исключения. 
**`string HelpLink`**               | Содержит URL документа с описанием исключения 
**`MethodBase`**, **`TargetSite`**  | Содержит метод, сгенерировавший исключение.

Порядок использования свойств класса System.Exception
---

```cs
try 
{ 
  int a = Int32.Parse(Console.ReadLine());   
  int b = Convert.ToInt32(Console.ReadLine()); 
} 
catch (Exception ex) // перехват исключений любого характера 
{ 
  Console.WriteLine(ex.Message);
  
  // Содержит имя сборки, сгенерировавшей исключение.
  Console.WriteLine(ex.Source);
  
  // Содержит URL документа с описанием исключения.
  Console.WriteLine(ex.HelpLink);
  
  // Содержит имена и сигнатуры методов, вызов которых привел к возникновению исключения.
  Console.WriteLine(ex.StackTrace); 
 
  // Содержит метод, сгенерировавший исключение. 
  Console.WriteLine(ex.TargetSite); 
} 
```

![](https://pp.userapi.com/c840237/v840237383/25294/N8t2eZojwv0.jpg)

Порядок использования свойств класса System.Exception
---

```cs
class MyClass 
{  public void MyMethod() 
    { 
        Exception exception = new Exception("Мое исключение"); 
        exception.HelpLink = "http://MyCompany.com/ErrorService"; 
        exception.Data.Add("Причина исключения: ", "Тестовое исключение"); 
        exception.Data.Add("Время возникновения исключения: ", DateTime.Now); 
        throw exception; 
    } 
}

class Program 
{ 
    static void Main() 
    {  
        try 
        {   
            MyClass instance = new MyClass(); 
            instance.MyMethod(); 
        } 
        catch (Exception e) 
        { 
            Console.WriteLine("Имя члена:               {0}", e.TargetSite); 
            Console.WriteLine("Класс :                  {0}", e.TargetSite.DeclaringType); 
            Console.WriteLine("Тип члена:               {0}", e.TargetSite.MemberType); 
            Console.WriteLine("Message:                 {0}", e.Message); 
            Console.WriteLine("Source:                  {0}", e.Source); 
            Console.WriteLine("Help Link:               {0}", e.HelpLink); 
            Console.WriteLine("Stack:                   {0}", e.StackTrace); 
            foreach (DictionaryEntry de in e.Data) 
                Console.WriteLine("{0} : {1}", de.Key, de.Value); 
        } 
    }
} 
```

![](https://pp.userapi.com/c639623/v639623663/3ac8f/JybCYcl43JU.jpg)

> **Формат записи try/catch/finally-блоков обработки исключений:**

```cs
try  
{ 
        //  Блок кода, в котором может возникнуть исключение 
} 
catch (тип исключения)  
{ 
        // Обработчик исключения 
} 
finally  
{ 
        // освобождение ресурсов 
}
...
```

Блок finally
---

```cs
try   
// Блок кода, где может произойти исключительная ситуация 
{ 
     Console.WriteLine("Блок try до генерации исключения"); 
     Console.Write("Генерировать исключение? (1-да/0-нет):"); 
     if (Console.ReadLine() == "1")  
         throw new IndexOutOfRangeException(); 
     Console.WriteLine("Блок try после генерации исключения"); 
} 
catch(Exception)  
// Блок кода, который должен обработать исключительную ситуацию 
{ 
    Console.WriteLine("Блок catch "); 
} 
finally 
{    
// Блок кода. который выполняется как при наличии исключения, так и без исключения! 
    Console.WriteLine("Блок finally "); 
} 
```

![](https://pp.userapi.com/c638927/v638927663/70a0a/MK4WFuORWzs.jpg)

Тонкости обработки исключений
---

```cs
try  
{ 
    // Блок кода, проверяемый на наличие ошибок. 
} 
catch (ExcepType1 exOb)  
{ 
    // Обработчик исключения типа ExcepType1. 
} 
catch (ExcepType2 exOb)  
{ 
    // Обработчик исключения типа ExcepType2. 
} 
...
```

```cs
try 
{  Console.Write("Введите число :  "); 
   string s = Console.ReadLine(); 
   int n = Convert.ToInt32(s); 
   if (n <= 0) 
   {
        // генерируется исключение ArgumentOutOfRangeException 
        // "n <= 0" - сообщение, которое выведется при исключении 
        throw new ArgumentOutOfRangeException("n <= 0"); 
   } 
   double f = Math.Log(n); 
   int d = 100 / (int)f; 
   Console.WriteLine("d = {0} f = {1}", d, f); 
}
catch (FormatException) 
{   // происходит, если введенное пользователем значение некорректно 
    Console.WriteLine("FormatException"); 
} 
catch (DivideByZeroException) 
{ 
   // происходит, если  Log(1) = 0  - 100/0 Деление на ноль 
   Console.WriteLine("DivideByZeroException"); 
} 
catch (Exception e) 
{ 
   // перехват всех  остальных  исключений 
   Console.WriteLine("Exception: {0}", e.Message);             
} 
```

Вложенные блоки try-catch
---

![](https://pp.userapi.com/c837230/v837230663/4fb72/yc0xYW3BCrk.jpg)

```cs
try  
{
    // Вложенный блок try-catch 
    try  
    { 
        // ...
    } 
    catch (ExcepType ex1)  
    {
        // ...
    } 
    finally  
    {
    
    } 
} 
catch (ExcepType ex2)  
{ 
   // ... 
} 
```

```cs
try   
{ 
    Console.WriteLine("Блок try до генерации исключения"); 
    try 
    { 
        Console.WriteLine(" ---- Влож. блок try  до исключения"); 
        switch (Console.ReadLine()) 
        { 
            case "1": throw new IndexOutOfRangeException();
            break; 
            case "2": throw new DivideByZeroException();
            break; 
            default: Console.WriteLine("Нет генерации исключений");
            break; 
        } 
        Console.WriteLine(" ---- Влож. блок try  - конец"); 
    } 
    catch (IndexOutOfRangeException ex) 
    {
        Console.WriteLine(" ---- Влож. блок catch ");
    } 
    finally 
    {
        Console.WriteLine(" ---- Влож. блок finally ");
    } 
        Console.WriteLine("Блок try  - конец"); 
    } 
catch (Exception ex)  
{
    Console.WriteLine("Блок catch");
} 
finally 
{
    Console.WriteLine("Блок finally");
} 
```

Повторная генерация исключений. Часть 1 
---

```cs
static void Main(string[] args) 
{
    try 
    {
        Test1();
    } 
    catch (Exception ex) 
    {
        Console.WriteLine(ex.Message);
    } 
} 

static void Test1() 
{ 
    try 
    { 
        Console.WriteLine(" * * * Генерация IndexOutOfRangeException"); 
        throw new IndexOutOfRangeException(); 
    } 
    catch (IndexOutOfRangeException ex) 
    { 
        Console.WriteLine(" * * * Обработка IndexOutOfRangeException"); 
        // повторная генерация исключения (типа IndexOutOfRangeException) 
        // для обработки catch более высокого уровня! 
        throw; 
    }
} 
```

![](https://pp.userapi.com/c836721/v836721525/614b8/kqIY0rIICpY.jpg)

Повторная генерация исключений. Часть 2 
---

```cs
static void Main(string[] args) 
{
  try 
  {
    Test1();
  } 
  catch (Exception ex) 
  {
  Console.WriteLine(ex.Message);    } 
  }

static void Test1() 
{ 
  try 
  { 
    Console.WriteLine(" * * * Генерация IndexOutOfRangeException"); 
    throw new IndexOutOfRangeException(); 
  } 
  catch (IndexOutOfRangeException ex) 
  { 
    Console.WriteLine(" * * * Обработка IndexOutOfRangeException"); 
    // повторная генерация исключения  
    throw new DivideByZeroException("Деление на ноль");   
  }
} 
```

![](https://pp.userapi.com/c837620/v837620690/657ee/IxDLKETHSKY.jpg)

Передача по стеку вызовов  (отличие  throw от throw ex)
---

![](https://pp.userapi.com/c639320/v639320690/50b3c/NnrhqstB710.jpg)

```cs
class Program
{
  static void Main(string[] args) 
    { 
      try 
      { 
        Method2(); 
      } 
      catch (Exception ex) 
      {
        Console.Write(ex.StackTrace.ToString()); 
        Console.ReadLine(); 
      } 
    } 
    static void Method2() 
    { 
      try 
      {
        Method1();
      } 
      catch (Exception ex) 
      {
      throw ex;          // throw;  
      } 
    } 
```

![](https://pp.userapi.com/c840130/v840130690/1f2cd/iRV4RttrhRQ.jpg)

```cs
    public  static void Method1() 
    { 
      try 
      {
      throw new Exception("This is thrown from Method1"); 
      }
      catch (Exception ex) 
      {
      throw;
      } 
    } 
}
```

![](https://pp.userapi.com/c639219/v639219690/44e94/Rt4_z4wSr9o.jpg)

Вложенные исключения
---

```cs
public class ClassWithException 
{ 
  public void ThrowInner() 
  {
    throw new Exception("Это внутреннее исключение!");
  } 
  public void CatchInner() 
  { 
    try 
  { 
    this.ThrowInner(); 
  } 
  catch (Exception e) 
  {
    throw new Exception("Это внешнее исключение!", e);
  }
}
```

```cs
static void Main() 
{ 
  ClassWithException instance = new ClassWithException(); 
  //instance.CatchInner(); // Попробовать вызвать. 
  try 
  {
  instance.CatchInner();
  }        
  catch (Exception ex) 
  {
  Console.WriteLine("Exception : {0}", ex.Message); 
  Console.WriteLine("Inner : {0}",     ex.InnerException.Message); 
  }
}
```

Необрабатываемые исключения
---

```cs
class Program 
{ 
  public static void Method() 
  { 
    int[] arr = new int[10]; 
    Console.WriteLine(arr); 
    Method(); // рекурсия 
  } 
  static void Main() 
  {
    try 
    { 
      Method(); 
    } 
    catch (Exception ex) 
    {
    Console.WriteLine(ex.Message);
    } 
    finally 
    { 
      // finally - не сработает при ошибке. 
      Console.WriteLine("Finally"); 
    } 
  }
} 
```

![](https://pp.userapi.com/c639818/v639818690/44f10/vNu1h-zipGs.jpg)

Исключение OutOfMemoryException
---

```cs
class Program 
{
  public static void Method() 
  { 
    int[] arr = new int[100000000]; 
    Console.WriteLine(arr); 
    Method(); 
  } 
 
  static void Main() 
  {
    try 
    { 
      Method(); 
    } 
    catch (Exception ex) 
    { 
      Console.WriteLine(ex.Message); 
    } 
    finally 
    { 
      // finally - сработает. 
      Console.WriteLine("Finally"); 
    } 
  }
}
```

Создание пользовательского исключения
---

```cs
public class UserException:Exception 
{    
  // конструкторы 
  public UserException () 
  { 
    // ...   
  } 
 
  // конструкторы для инициализации св-ва Message 
  public UserException (string message) : base(message)  
  {          
    // ... 
  } 
} 
```

Применение конструкций checked и unchecked
---

```cs
Byte b1 = 100;  // byte хранит числа от 0 до 255 (всего 256) 
                // b1 = 300 - 256 = 44 – разряды, которые  не попадают отбрасываются 
b1 = (Byte)(b1 + 200);    
Console.WriteLine("Результат: " + b1); 
             
Byte b2 = 100; 
try 
{
  // контроль за переполнением и генерация исключения  
  b2 = checked((Byte)(b2 + 200));    
  Console.WriteLine("Результат checked: " + b2); 
}  
catch(OverflowException ex) 
{
  Console.WriteLine(ex.Message);
} 

Byte b3 = 100; 
try 
{
  // игнорирование переполнения 
  b3 = unchecked((Byte)(b3 + 200));   
  Console.WriteLine("Результат unchecked: " + b3); 
} 
catch (OverflowException ex) 
{
  Console.WriteLine(ex.Message);
} 
```

![](https://cs541603.userapi.com/c840628/v840628690/50cc/XUKqgdM3uuc.jpg)

Фильтры исключений
---

![](https://pp.userapi.com/c841329/v841329690/1da3f/jAM86Tike7Y.jpg)

Генерация исключений
---

![](https://pp.userapi.com/c639230/v639230690/4157a/v6MAX1HUQSk.jpg)

***

![](https://pp.userapi.com/c840528/v840528690/58ac/nAR9Ze1fQ14.jpg)

***

![](https://pp.userapi.com/c841224/v841224690/1d9bc/06B7lGfho90.jpg)

***

![](https://pp.userapi.com/c639521/v639521690/49dbe/8nJ6xsrXqVw.jpg)

Как правильно использовать исключения
---

![](https://pp.userapi.com/c837434/v837434690/52ef2/Y6LI0uQpMcU.jpg)

Рекомендации по обработке и генерации исключений
---

![](https://pp.userapi.com/c840722/v840722690/5abd/WA4AMAnp0f4.jpg)

***

[**-->     HomeWork5     <--**]()

**11.09.2017**

[**<-- Введение в классы**](https://github.com/SuvStreet/IT_Step_C_Sharp/blob/master/ClassWork/Day4/README.md#Введение-в-классы) `=/=` [** -->**]()

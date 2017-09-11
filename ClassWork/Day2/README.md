> **Материал подготовлен преподавателем Комаров Иван Николаевич по курсу "Платформа Microsoft.NET и язык программирования С#". Учебное заведение "Компьютерная Академия Шаг".**

Основы языка программирования C#
===

![](https://pp.userapi.com/c840722/v840722215/4f5c/B0ug8YSDcnQ.jpg)

* **Программа «Hello, World» на языке Cи с использованием WinAPI**

```cpp
#include <windows.h> 
LRESULT CALLBACK WndProc(HWND hwnd, UINT msg, WPARAM wparam, LPARAM lparam); 
INT WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInstance, LPSTR cmdline, int cmdshow) { 
  MSG msg; 
  HWND hwnd; 
  WNDCLASSEX wndclass = { 0 }; 
  wndclass.cbSize = sizeof(WNDCLASSEX); 
  wndclass.style = CS_HREDRAW | CS_VREDRAW; 
  wndclass.lpfnWndProc = WndProc; 
  wndclass.hIcon = LoadIcon(NULL, IDI_APPLICATION); 
  wndclass.hCursor = LoadCursor(NULL, IDC_ARROW); 
  wndclass.hbrBackground = (HBRUSH)GetStockObject(WHITE_BRUSH);
  wndclass.lpszClassName = TEXT(«Window1»); 
  wndclass.hInstance = hInstance; 
  wndclass.hIconSm = LoadIcon(NULL, IDI_APPLICATION); 
  RegisterClassEx(&wndclass); 
  hwnd = CreateWindow(TEXT(«Window1»), TEXT(«Hello World»), WS_OVERLAPPEDWINDOW, CW_USEDEFAULT, 0,
         CW_USEDEFAULT, 0, NULL, NULL, hInstance, NULL); 
  
  if( !hwnd ) return 0;
  
  ShowWindow(hwnd, SW_SHOWNORMAL);
  UpdateWindow(hwnd);
  
  while( GetMessage(&msg, NULL, 0, 0) )  
  { 
        TranslateMessage(&msg); 
        DispatchMessage(&msg); 
  }
  return msg.wParam; 
}

LRESULT CALLBACK WndProc(HWND hwnd, UINT msg, WPARAM wparam, LPARAM lparam) { 
  switch(msg) { 
  
    case WM_DESTROY: 
      PostQuitMessage(WM_QUIT); 
      break;
    
    default: 
      return DefWindowProc(hwnd, msg, wparam, lparam); 
  } 
  return 0;
} 
```

* **Программа «Hello, World» на языке Java**

```js
import java.awt.event.*; 
import java.awt.*; 
class simpleFrame extends Frame {     
public static void main(String[] args) { 
  simpleFrame a= new simpleFrame(" Hello, World "); 
  } 
  simpleFrame(String title) {   
    setTitle(title); 
    show(); 
  }
} 
```

* **Программа «Hello, World» на языке C# платформа .NET**

```cs
using System.Windows.Forms; 
using System; 
class Program  
{
    [STAThread] static void Main()  
    {
         Form myForm = new Form(); 
         myForm.Text = «Hello World»; 
         Application.Run(myForm); 
    }
}
```

Впервые язык C# увидел свет в середине 2000 года. Главным архитектором С# был **Андерс Хейлсберг (Anders Hejlsberg)**. 

Достоинства языка C#
---

* Не  требуется  применение указателей.  
* Автоматическое управление памятью через сборку мусора.  
* Наличие  перегрузки  операций  для пользовательских  типов  без  лишних сложностей (по сравнению с С++) 
* Полная  поддержка  техники программирования,  основанной  на использовании интерфейсов 
* и ряд других ... 

![](https://cs541603.userapi.com/c836336/v836336215/67d2a/p3udY3ugYok.jpg)

[Общая информация по версиям](https://ru.wikipedia.org/wiki/C_Sharp#.D0.92.D0.B5.D1.80.D1.81.D0.B8.D0.B8)
---

![](https://pp.userapi.com/c841532/v841532215/1ab0f/gAaazgZNdpU.jpg)

![](https://pp.userapi.com/c840624/v840624758/6366/TgkK-jLRGqA.jpg)

[Standart C# Language Specification](http://www.ecma-international.org/publications/files/ECMA-ST/Ecma-334.pdf)

Общая структура программы на языке программирования C#
---

```cs
//  1. ПОДКЛЮЧЕНИЕ ДЛЯ ИСПОЛЬЗОВАНИЯ НЕОБХОДИМЫХ ПРОСТРАНСТВ ИМЕН 
using System;   
//  2. ОПРЕДЕЛЕНИЕ ПРОСТРАНСТВА ИМЕН ТЕКУЩЕГО ПРОЕКТА 
namespace Lekcija2   
{ 
//  3. ОБЪЯВЛЕНИЕ КЛАССА Program 
    class Program    
    { 
//  4. ОСНОВНАЯ ФУНКЦИЯ (МЕТОД) ПРОГРАММЫ 
        public static void Main() 
        {
//  5. МЕСТО,  В КОТОРОМ РЕАЛИЗУЕТСЯ  ОСНОВНАЯ ЛОГИКА ПРОГРАММЫ 
        } 
    } 
} 
```

Пример программы, в которой выводятся сообщения на экран
---

```cs
using System;       // подключение для использования пространства имен 
namespace Lekcija2  // определение пространства имен текущего проекта 
{
  class Program     // объявление класса Program 
  { 
    public static void Main() // Основная функция (метод) программы 
    { 
      // Вывод сообщения на экран 
      Console.WriteLine("Первая программа!"); 
        
      Console.Write("Для продолжения нажмите клавишу..."); 
      Console.Read();               
    }
  }
} 
```

![](https://pp.userapi.com/c836229/v836229751/75570/HTTnhW6Ip60.jpg)

Основы языка программирования C#
---

**Тип данных определяют**
* множество  значений,  которые  может принимать объект (экземпляр этого типа);  
* множество  операций,  которые  допустимо выполнять над ним;  
* способ  хранения  объектов  в  оперативной памяти. 

Под  типом  понимается  ***классы,  интерфейсы,  структуры, перечисления и делегаты***

![](https://pp.userapi.com/c638130/v638130751/6626d/lvlEye9CCBM.jpg)

Название       | .NET Class | Наличие знака | Размер в битах  | Диапозон значений
---------------|------------|---------------|-----------------|---------------------
**`byte`**     | Byte       | -             | 8               | От `0` до `255`
**`sbyte`**    | Sbyte      | +             | 8               | От `-128` до `127`
**`short`**    | Int16      | +             | 16              | От `-32 768` до `32 767`
**`ushort`**   | Uint16     | -             | 16              | От `0` до `65 535`
**`int`**      | Int32      | +             | 32              | От `-2 147 483 648` до `2 147 483 647`
**`uint`**     | Uint32     | -             | 32              | От `0` до `4 294 967 295`
**`long`**     | Int64      | +             | 64              | От `-9 223 372 036 854 775 808` до `9 223 372 036 854 775 807`
**`ulong`**    | Uint64     | -             | 64              | От `0` до `18 446 744 073 709 551 615`
**`float`**    | Single     | +             | 32              | От `-1,175494351e38` до `3,402823466e38`
**`double`**   | Double     | +             | 64              | От `-2,2250738585072014e308` до `1,7976931348623158e308`
**`decimal`**  | Decimal    | +             | 128             | От `-1,0*10e28` до `7,9*10e28`

```cs
  decimal devidend = 1; 
//нижеследующая строка выводит в консоль 1 
  Console.WriteLine(devidend); 
  decimal devisor = 3; 
  devidend = devidend / devisor; 
//нижеследующая строка выводит в консоль 0,33333333333333333333333333 
  Console.WriteLine(devidend);             
//нижеследующая строка выводит в консоль 0,99999999999999999999999999 
  Console.WriteLine(devidend * devisor); 
 
//вывод - ошибки округления привели к потере данных 
             
  double doubleDevidend = 1; 
//нижеследующая строка выводит в консоль 1 
  Console.WriteLine(doubleDevidend); 
  double doubleDevisor = 3; 
  doubleDevidend = doubleDevidend / doubleDevisor; 
//нижеследующая строка выводит в консоль 0,33333333333333 
  Console.WriteLine(doubleDevidend); 
//нижеследующая строка выводит в консоль 1 
  Console.WriteLine(doubleDevidend * doubleDevisor); 
```

Полезные методы
---

```cs
//определяет является ли символ управляющим 
char.IsControl('\t')                //true 

//определяет является ли символ цифрой 
char.IsDigit('5')                   //true 

//определяет является ли символ бувенным 
char.IsLetter('x')                  //true 

//определяет находится ли символ в нижнем регистре 
char.IsLower('m')                   //true 

//определяет находится ли символ в верхнем регистре 
char.IsUpper('P')                   //true 

//определяет является ли символ знаком пунктуации 
char.IsPunctuation(',')             //true 
 
//определяет является ли символ специальным символом 
char.IsSymbol('<')                  //true 
 
//определяет является ли символ пробелом 
char.IsWhiteSpace(' ')              //true 
 
//переводит символ в нижний регистр 
char.ToLower('T')                   //t 
 
//переводит символ в верхний регистр 
char.ToUpper('t')                   //T 
```

Литералы
---

**`Литералами`**  называются  постоянные значения,  представленные  в  удобной  для восприятия форме. Используются для представления значений в исходном коде.

* `Булевы литералы`
  * **true (истина)**
  * **false (ложь)** 

* `Целые литералы`
  * **int**
  * **u – uint**
  * **l - long**

* `Действительные литералы`
  * **f или F – float**
  * **d или D – double (по умолчанию)** 
  * **m или M - decimal** 

* `Символьные литералы`
  * **отдельный символ ‘$’**

* `Строковые литералы`
  * **регулярные  “Строка”**
  * **буквальные  @“Строка”**

* `Литерал`
  * **null**

Управляющие символы
---

Символ    | Действие управляющего символа
----------|---------------------
**`\a`**  | Звуковой сигнал
**`\b`**  | Возврат на одну позицию
**`\f`**  | Переход к началю следующей страницы
**`\n`**  | Новая строка
**`\r`**  | Возврат каретки
**`\t`**  | Горизонтальная табуляция
**`\v`**  | Вертикальная табуляция
**`\0`**  | Нуль-символ (символ конца строки)
**`\'`**  | Одинарная кавычка
**`\"`**  | Двойная кавычка
**`\\`**  | Обратная косая черта

Класс String
---

Представляет текст как последовательность знаков Юникода. 

```cs
string str = "Привет, C#"; 
```

Метод Object.ToString 
---

Возвращает строковое представление текущего объекта. 

```cs
int a = 100; 
string str = a.ToString();
```

Полезные методы
---

```cs
   string str = "hello :)"; 
   string anotherString = (string)str.Clone();                 
   Console.WriteLine(anotherString);
//выводит: "hello :)"

   Console.WriteLine(str.Contains("hello"));
//выводит: true

   Console.WriteLine(str.Insert(6, "world"));
//выводит: "hello world:)"

   Console.WriteLine(str.Remove(5, 1));
//выводит: "hello:)"

   Console.WriteLine(str.Replace(":)", ":("));
//выводит: "hello :("

   Console.WriteLine(str.StartsWith("hell")); 
//выводит: "true"

   Console.WriteLine(str.Substring(6)); 
//выводит: ":)"

   Console.WriteLine(str.ToUpper()); 
//выводит: "HELLO :)" 
    
   str = "       " + str + "       "; 
   str = str.Trim(); 
   Console.WriteLine(str);          
//выводит: "hello :)"
```

Переменные
---

**`Переменная`** – это  именованный  объект, хранящий значение некоторого типа данных. 

Объявление переменных
---

В общем случае, переменная на C# объявляется так: **тип_переменной имя_переменной**; 
 
Пример объявления переменных различных типов 

```cs
int A;  double B;    char C;   string Str;     bool X;
```

В  одном  объявлении  можно  с  помощью  запятой  указать  несколько переменных, при этом все объявленные переменные будут иметь один и тот  же тип.

```cs
int A1, A2, A;    double B, F, D; 
```

Инициализация переменных
---

```cs
int  A;   double B, F, D;   char C;   string Str;         bool X; 
A = 29;   B = 0.5;          C='@';    Str = "Язык С#";    X = true;
          F = -12.34;
          D = 125.6;
```

Присвоить значение переменным можно также при их объявлении.

```cs
int  A = 29; 
double B = 0.5, F = -12.34, D = 125.6;
char C='@';       
string Str = "Язык С#";
bool X = true; 
```

Ввод, вывод в консольном приложении
---

```cs
class Program
{
  static void Main()
  {
    int km = 58;
    int m = 20;
    Console.WriteLine("Дальность до цели - " + km + ", " + m);
    Console.WriteLine("Дальность до цели - {0}, {1}", km, m);
    Console.Read();
  }
}
```

![](https://pp.userapi.com/c841424/v841424010/1b961/G7QHxb1wtUw.jpg)

```cs
Console.WriteLine("{argNum, width:tmt}", C);
```

```cs
// В этом примере кода показано Console.WriteLine() метод.
// Форматирование в этом примере используется "en-US" культуры.

using System;
class Sample 
{
  enum Color {Yellow = 1, Blue, Green};
  static DateTime thisDate = DateTime.Now;

  public static void Main() 
  {
    Console.Clear();

// Отрицательное, целое или число с плавающей запятой вывод различными способами
Console.WriteLine( "Стандартный цифровой формат" );
Console.WriteLine( "(C) Currency: . . . . . . . . {0:C}\n"+ 
                   "(D) Decimal:. . . . . . . . . {0:D}\n" +  
                   "(E) Scientific: . . . . . . . {1:E}\n" +  
                   "(F) Fixed point:. . . . . . . {1:F}\n" +  
                   "(G) General:. . . . . . . . . {0:G}\n" +
                   "    (default):. . . . . . . . {0} (default = 'G')\n" +
                   "(N) Number: . . . . . . . . . {0:N}\n" +  
                   "(P) Percent:. . . . . . . . . {1:P}\n" +  
                   "(R) Round-trip: . . . . . . . {1:R}\n" +  
                   "(X) Hexadecimal:. . . . . . . {0:X}\n", -123, -123.45f);

// Формат текущей даты вывод различными спосабами
Console.WriteLine( "Стандартные спецификации формата DateTime" );
Console.WriteLine( "(d) Short date: . . . . . . . {0:d}\n" +
                   "(D) Long date:. . . . . . . . {0:D}\n" +
                   "(t) Short time: . . . . . . . {0:t}\n" +
                   "(T) Long time:. . . . . . . . {0:T}\n" +
                   "(f) Full date/short time: . . {0:f}\n" +
                   "(F) Full date/long time:. . . {0:F}\n" +
                   "(g) General date/short time:. {0:g}\n" +
                   "(G) General date/long time: . {0:G}\n" +
                   "    (default):. . . . . . . . {0} (default = 'G')\n" +
                   "(M) Month:. . . . . . . . . . {0:M}\n" +
                   "(R) RFC1123:. . . . . . . . . {0:R}\n" +
                   "(s) Sortable: . . . . . . . . {0:s}\n" +
                   "(u) Universal sortable: . . . {0:u} (invariant)\n" +
                   "(U) Universal full date/time: {0:U}\n" +
                   "(Y) Year: . . . . . . . . . . {0:Y}\n", thisDate);

// Отформатированые значения перечисления цвета различными способами
Console.WriteLine( "Стандартные спецификации формата перечисления" );
Console.WriteLine( "(G) General:. . . . . . . . . {0:G}\n" +
                   "    (default):. . . . . . . . {0} (default = 'G')\n" +
                   "(F) Flags:. . . . . . . . . . {0:F} (flags or integer)\n" +
                   "(D) Decimal number: . . . . . {0:D}\n" +
                   "(X) Hexadecimal:. . . . . . . {0:X}\n", Color.Green);       
    }
}

/*
В этом примере кода будут следующие результаты:

Стандартный цифровой формат
(C) Currency: . . . . . . . . ($123.00)
(D) Decimal:. . . . . . . . . -123
(E) Scientific: . . . . . . . -1.234500E+002
(F) Fixed point:. . . . . . . -123.45
(G) General:. . . . . . . . . -123
    (default):. . . . . . . . -123 (default = 'G')
(N) Number: . . . . . . . . . -123.00
(P) Percent:. . . . . . . . . -12,345.00 %
(R) Round-trip: . . . . . . . -123.45
(X) Hexadecimal:. . . . . . . FFFFFF85

Стандартные спецификации формата DateTime
(d) Short date: . . . . . . . 6/26/2004
(D) Long date:. . . . . . . . Saturday, June 26, 2004
(t) Short time: . . . . . . . 8:11 PM
(T) Long time:. . . . . . . . 8:11:04 PM
(f) Full date/short time: . . Saturday, June 26, 2004 8:11 PM
(F) Full date/long time:. . . Saturday, June 26, 2004 8:11:04 PM
(g) General date/short time:. 6/26/2004 8:11 PM
(G) General date/long time: . 6/26/2004 8:11:04 PM
    (default):. . . . . . . . 6/26/2004 8:11:04 PM (default = 'G')
(M) Month:. . . . . . . . . . June 26
(R) RFC1123:. . . . . . . . . Sat, 26 Jun 2004 20:11:04 GMT
(s) Sortable: . . . . . . . . 2004-06-26T20:11:04
(u) Universal sortable: . . . 2004-06-26 20:11:04Z (invariant)
(U) Universal full date/time: Sunday, June 27, 2004 3:11:04 AM
(Y) Year: . . . . . . . . . . June, 2004

Стандартные спецификации формата перечисления
(G) General:. . . . . . . . . Green
    (default):. . . . . . . . Green (default = 'G')
(F) Flags:. . . . . . . . . . Green (flags or integer)
(D) Decimal number: . . . . . 3
(X) Hexadecimal:. . . . . . . 00000003
*/
```

[Console.WriteLine - метод (String, Object, Object)](https://msdn.microsoft.com/ru-ru/library/aakt1eab(v=vs.100).aspx)

```cs
    // Title  возвращает (устанавливает) текст заголовка окна консоли. 
Console.Title = "Ввод/вывод средствами класса Console";

    // BackgroundColor – возвращает или устанавливает фоновый цвет выводимого в консоль текста 
Console.BackgroundColor=ConsoleColor.Gray;

    //CursorVisible  –  возвращает  или  устанавливает  значение  индикатора  видимости  курсора 
Console.CursorVisible = false;

    // ForegroundColor – возвращает или устанавливает фоновый цвет выводимого в консоль текста 
Console.ForegroundColor=ConsoleColor.Green;
Console.WriteLine("Ввод/вывод средствами класса Console");

   // ResetColor – сбрасывает значение цвета текста и фона 
Console.ResetColor(); 
Console.WriteLine("Ввод/вывод средствами класса Console"); 
```

[Console - класс](https://msdn.microsoft.com/ru-ru/library/System.Console(v=vs.100).aspx)

![](https://pp.userapi.com/c639623/v639623432/3ff1d/-OpRgFIskso.jpg)

Значимые и ссылочные типы
---

![](https://pp.userapi.com/c840538/v840538243/54f3/RIwL-ljcAOA.jpg)

![](https://pp.userapi.com/c836637/v836637243/61278/Q_bjAMwzGTk.jpg)

![](https://pp.userapi.com/c836334/v836334243/5eda3/sHVix_Fs1Qk.jpg)


29













**05.09.2017**

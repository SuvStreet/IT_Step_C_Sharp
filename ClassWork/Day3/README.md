> **Материал подготовлен преподавателем Комаров Иван Николаевич по курсу "Платформа Microsoft.NET и язык программирования С#". Учебное заведение "Компьютерная Академия Шаг".**

Массивы и строки
===

**`Массив`** представляет собой совокупность переменных одного типа, расположенных в памяти непосредственно друг за другом, с общим для обращения к ним именем.

![](https://pp.userapi.com/c836736/v836736044/699f2/nztL3w_XkhY.jpg)

Особенности массивов в C#
---

* Все массивы в С# унаследованы от класса System.Array.
**`Следовательно:`**
  * наличие методов различного назначения
  * освобождение памяти сборщиком мусора
* Изменен синтаксис объявления массивов
* После выделения памяти инициализация элементов происходит следующим образом: значения всех простых типов устанавливаются в «0», значения логического типа – в false, ссылки – в null.

![](https://pp.userapi.com/c841426/v841426044/1f9bd/61P8uKnvjmI.jpg)

Объявление и инициализация массивов
---

![](https://pp.userapi.com/c639627/v639627044/435d2/I1HkisBRQc0.jpg)

![](https://sun9-11.userapi.com/c840625/v840625044/6938/sbNim_NWiNY.jpg)

```cs
byte[] array = new byte[3];

array[0] = 10;
array[1] = 20;
array[2] = 30;

Console.WriteLine(array[0]);
Console.WriteLine(array[1]);
Console.WriteLine(array[2]);
```

![](https://pp.userapi.com/c639620/v639620044/492f4/ao62PTp4cw0.jpg)

```cs
// объявление массива (целых чисел)
int[] mas1;  mas1 = new int[5];
int[] mas2 = new int[5];
            
// объявление массива + инициализация
int[] mas3 = new int[5]{1,2,3,4,5};
int[] mas4 = new int[] { 1, 2, 3, 4, 5 };  // размер массива опеределяется кол-вом элементов в инициализаторе
int[] mas5 =  { 1, 2, 3, 4, 5 };

// объявление массива (строки)
string[] info = { "Фамилия", "Имя", "Отчество" };

// объявление массива (символы)
char[] symbol = new char[4] { 'X', 'Y', 'Z', 'M' };
```

Многомерные массивы
---

Массивы имеющие более одного индекса.

Многомерные массивы:
* Прямоугольные - которые содержат несколько измерений, где все строки имеют одинаковую длину.

![](https://sun9-11.userapi.com/c837726/v837726044/66435/KfSgIQ967F4.jpg)

* Зубчатые - Массивы, которые содержат некоторое количество внутренних массивов, каждый из которых может иметь собственный уникальный верхний предел.

![](https://pp.userapi.com/c841637/v841637044/1b035/runzzXeifn0.jpg)

Двумерный, трехмерногоый массив (Прямоугольные)
---

**`Двумерный массив`** — прямоугольный массив содержащий два индекса.

```cs
int[,] array = new int[3,3];
```

![](https://pp.userapi.com/c837524/v837524044/62150/GoLNXzsqzqw.jpg)

![](https://pp.userapi.com/c836337/v836337044/5ff3b/plNaT09Yqd4.jpg)

```cs
byte[,] array = new byte[2,2];

array[0,0] = 10;
array[0,1] = 20;
array[1,0] = 30;
array[1,1] = 40;

Console.WriteLine(array[0,0]);
Console.WriteLine(array[0,1]);
Console.WriteLine(array[1,0]);
Console.WriteLine(array[1,1]);
```

```cs
// объявление двумерного массива + инициализация
int[,] mas2D = new int [3,2] { {1,2}, {3,4}, {5,6} };
```

```cs
// объявление трехмерного массива + инициализация
int[, ,] myArr = new int[5, 5, 5];
for (int i = 0; i < 5; i++)
   for (int j = 0; j < 5; j++)
       for (int k = 0; k < 5; k++)
            myArr[i, j, k] = i + j + k;
```

Рваные массивы (Зубчатые)
---

```cs
тип[][] имя_массива = new тип [размер][];
```

```cs
// Создание внешнего массива на две ячейки
int[][] myArr = new int[2][];
// Создание внутреннего массива в первой ячейке
myArr[0] = new int[] { 1, 2 };
// Создание внутреннего массива во второй ячейке
myArr[1] = new int[] { 3, 4, 5, 6 };
```

![](https://pp.userapi.com/c836737/v836737044/6f30d/cEW9cE4q2dc.jpg)

```cs
byte[][] array = new byte[3][];

array[0] = new byte[] {10, 20};
array[1] = new byte[] {30, 40, 50, 60};
array[2] = new byte[] {70, 80, 90};
```

![](https://sun9-11.userapi.com/c836537/v836537044/5e8c9/R97vEKXvOvs.jpg)

```cs
int size = 5;
// Объявление вложеного массива
int[][] myArr = new int[size][];

for (int i = 0; i < size; i++)
{
  // Создание внутренних массивов
  myArr[i] = new int[i + 1];
  for (int j = 0; j < i + 1; j++)
  {
    // Заполнение внутренних массивов
    myArr[i][j] = j + 1;
    // Вывод на экран элементов
    Console.Write(myArr[i][j] + " ");
  }
Console.WriteLine();
}
```

Класс Array
---

```cs
int[] myArr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };       // объявление массива myArr1
PrintArr("Массив myArr1", myArr1);                      // вызов метода для вывода элементов массива на экран

Console.WriteLine("Размер массива: "+myArr1.Length);                                
Console.WriteLine("Максимальный элемент в массиве myArr1: " + myArr1.Max());        
Console.WriteLine("Минимальный элемент в массиве myArr1: " + myArr1.Min());         
Console.WriteLine("Среднее арифметическое элементов myArr1: " + myArr1.Average());
Console.WriteLine("Сумма элементов" + myArr1.Sum());

Array.Reverse(myArr1);                                     // Реверсирование всего массива
PrintArr("Массив myArr1 после реверсирования", myArr1);
            
Array.Sort(myArr1);                                        // Сортировка всего массива
PrintArr("Массив myArr1 после сортировки", myArr1);

Console.WriteLine("Число 5 находится в массиве на " + Array.BinarySearch(myArr1, 5) + " позиции");

Array.Reverse(myArr1, 3, 4);                               // Реверсирование 4-ех элементов массива начиная с (3+1)-го элемента
PrintArr("Массив myArr1 после реверсирования", myArr1);

int[] myArr2 = new int[20];                                // объявление нового массива myArr2 (заполнение нулями)
PrintArr("Массив myArr2 до копирования", myArr2);

myArr1.CopyTo(myArr2,0);                                  // копирование из myArr1  в  myArr2
PrintArr("Массив myArr2 после копирования", myArr2);
            
Array.Clear(myArr2, 0, myArr2.Length);
PrintArr("Массив myArr2 после очистки: ", myArr2);         // копирование из myArr1  в  myArr2

int[] tempArr = (int[])myArr1.Clone();                     // Клонирование массива из существующего
PrintArr("Склонированный массив tempArr", tempArr);

Console.WriteLine("Индекс элемента 9 в массиве - "+Array.BinarySearch(myArr1, 9));

Console.WriteLine("Индекс 9 в массиве (первый) - " + Array.IndexOf(myArr1, 9));
Console.WriteLine("Индекс 9 в массиве (последний)- " + Array.LastIndexOf(myArr1, 9));

int[] myArr3 = new int[20];    
Array.Copy(myArr1, myArr3,10);
PrintArr("Массив myArr3 после копирования: ", myArr3);

Array.Clear(myArr1, 0, 10); //очистка массива

int[,] myArr4 = { { 1, 2, 3 }, { 4, 5, 6 } };
Console.WriteLine("Количество измерений массива myArr3: " + myArr4.Rank);
```

* Метод **GetLength** возвращает количество элементов масива по заданному измерению:

```cs
int[, ,] a = new int[10, 11, 12];
Console.WriteLine(a.Length); // 1320
Console.WriteLine(a.GetLength(0)); // 10
Console.WriteLine(a.GetLength(1)); // 11
Console.WriteLine(a.GetLength(2)); // 12
```

* Методы **GetLowerBound** и **GetUpperBound** возвращают соотвественно нижнию и верхнию границы массива по заданному измерению (например, если одномерный массив на 5 элементо, то нижняя граница будет "0", верхняя - "4").

* Статический метод **Clear** очищает массив (диапозон массива). При этом ссылочные элементы устанавливаются в **null**, логические - в **false**, типы значений - в "0".

* Статический метод **Resize** изменяет размер массива.

Строки
---

`String` представляет собой неизменяемый упорядоченный набор символов. Он является ссылочным типом и по этой причине строки всегда размещаются в куче и никогда - в стеке.

**String** считается элементарным типом (компилятор разрешает вставлять литеральные строки непосредственно в исходный код). Компилятор помещает эти литеральные строки в метаданные при компиляции, в процессе выполнения строки загружаются и на них ссылаются переменные типа String.

```cs
String str = "Работа состроками";
```

```cs
void Main()                IL_0000: nop
{                          IL_0001: ldstr "C# 6.0"
  String str="C# 6.0";     IL_0006: stloc.0 // str
  Point p=new Point();     IL_0007: newobj UserQuery+Point..ctor
}                          IL_000C: stloc.1 // p
                           IL_000D: ret
```

Класс String. Особенности применения
---

```cs
String str1 = "Работа со строками" + Environment.NewLine + "в C#";
```

Задавать последовательность символов конца строки и перевода каретки ("\n") напрямую не рекомендуется. Лучше использовать `Environment.NewLine`, который зависит от платформы и возвращает ту строку, которая обеспечивает создание разрыва строк на конкретной платформе

```cs
String file = "C:\\ Windows\\System32\\Noteped.exe";
String file = @"C:\ Windows\System32\Noteped.exe";

String strUserName = "Ivan" + " " + "C#";
```

Компилятор выполняет конкатенацию литеральных строк на этапе компиляции, в результате в метаданных модуля оказывается одна строка "Ivan  C#". Конкатенация нелитеральных строк с помощью оператора «+» происходит  на  этапе  выполнения.  Конкатенацию  строк  оператором  «+» лучше не выполнять т.к. создается много строковых объектов.

```cs
strUserName.Substring(0, 4).ToUpper().EndsWith(" .NET");
```

объект String – неизменяем, созданную однажды строку нельзя сделать длиннее или короче, в ней нельзя изменить ни одного символа. Если выполняется много операций со строками, в куче создается много объектов String.

```cs
// Сравнение строк
Boolean Equals(Srting value, StringComparison comparisonType) {}

static Boolean Equals(Srting a, Srting b, StringComparison comparisonType) {}

static Int32 Compare(Srting strA, Srting strB, StringComparison comparisonType) {}

static Int32 Compare(srting strA, srting strB, Boolean ignoreCase, CultureInfo culture) {}


public enum StringComparison
{
  CurrentCulture = 0,
  CurrentCultureIgnoreCase = 1,
  IvariantCulture = 2, // не зависящий от языка и региональных параметров
  IvariantCultureIgnoreCase = 3,
  Ordinal = 4,
  OrdinalIgnoreCase = 5;
}

Ordinal comparison: 'Strasse' != 'StrBe';
Cultural comparison: 'Strasse' == 'StrBe';
```

Инmepниpoвaние строк (string interning)
---

Используется для повышения производительности, если  в приложении ожидается появление множества  одинаковых строковых объектов. 

При инициализации CLR создает внутреннюю хэш-таблицу, в которой ключами являются строки, а значениями - ссылки на строковые объекты в управляемой куче.

Регулируется настройками сборки (атрибутом).

```cs
// отключено интернирование строк
String s1 = "Ivan";
String s2 = "Ivan";
Console.WriteLine(Object.ReferenceEquals(s1, s2)); // False

s1 = String.Intern(s1);
s1 = String.Intern(s2); // Находит в хэш-таблице и возвращает ссылку
Console.WriteLine(Object.ReferenceEquals(s1, s2)); //True
```

Класс String. Основные методы
---

```cs
// Реверсирование строки
char[] chrArrFull = str.ToCharArray();
Array.Reverse(chrArrFull);
Console.Write(chrArrFull);                     

Console.WriteLine("\nКопирование строки в массив символов");
// Копируем шесть символов начиная с восьмой позиции и помещаем в массив символов
str.CopyTo(8, chrArr, 0, 6);
Console.WriteLine(chrArr);

// Вывод подстроки с 11 символа по 23-й (12 - размер)
str1.Substring(11, 12)

// Замена подстроки
str4 = str4.Replace("учу", "изучаю");

// Вставка строки (2 - индекс) + приведение к верхнему регистру
str4 = str4.Insert(2, "настройчиво ").ToUpper();

// Проверка наличия строки
str4.Contains("настройчиво")
```


24





```






***

[**-->     HomeWork3     <--**]()

**06.09.2017**

[**<-- Основы языка программирования C#**](https://github.com/SuvStreet/IT_Step_C_Sharp/tree/master/ClassWork/Day2#Основы-языка-программирования-c) `=/=` [**Введение в классы -->**](https://github.com/SuvStreet/IT_Step_C_Sharp/tree/master/ClassWork/Day4#Введение-в-классы)

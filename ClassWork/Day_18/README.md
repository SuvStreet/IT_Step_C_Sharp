> **Материал подготовлен преподавателем Комаров Иван Николаевич по курсу "Платформа Microsoft.NET и язык программирования С#". Учебное заведение "Компьютерная Академия Шаг".**

Основы XML
===

![](https://sun9-16.userapi.com/c840621/v840621572/1065f/7GAhsTesIpw.jpg)

**`XML (eXtensible Markup Language, расширяемый язык разметки)`**

Это универсальный способ описания структурированных данных, т.е. данных, которые обладают заданным набором семантических атрибутов и допускают иерархическое описание. XML-данные содержатся в документе, в роли которого может выступать файл, поток или другое хранилище информации, способное поддерживать текстовый формат.

**`Основное назначение`**

Язык XML предназначен для хранения и передачи данных.

**`Теги XML не предопределены`**, что даёт возможность самостоятельно определять необходимые теги, т.е. **`XML - самоопределяемый`**.

Язык XML разработан рабочей группой XML консорциума World Wide Web Consortium (Working Group XML W3C) (1998)

**Плюсами языка являются:**
* **`Независимость`** от платформы, операционной системы и программ обработки
* Представление **`произвольных данных`** и дополнительной метаинформации
* XML позволяет хранить и упорядочивать информацию почти **`любого рода`** в формате, приспособленном к потребностям пользователя
* Используя **`Unicode`** в качестве стандартного набора символов, XML поддерживает внушительное число различных систем письма и символов, от скандинавских рунических символов до китайских идеографов Хань
* XML предоставляет несколько способов **`проверки качества документа`** путем применения синтаксических правил, внутренней проверки ссылок, сравнения с моделями документов и типов данных
* Благодаря простому и понятному синтаксису, а также однозначной структуре, **`XML легко читается и анализируется`**, как человеком, так и программами.

Общее представление об XML
---

![](https://pp.userapi.com/c837439/v837439572/58f97/JRmHjgjsek0.jpg)

Тело документа XML состоит из элементов разметки (XML - тэги) (markup) и непосредственно содержимого документа - данных (content)

XML - тэги предназначены для определения элементов документа, их атрибутов и других конструкций языка

Дерево XML
---

XML документы формируют **`древовидную структуру`**, которая начинается с **`«корневого»`** элемента и разветвляется на **`«дочерние»`** элементы.

![](https://sun9-16.userapi.com/c841235/v841235572/24499/CX0qtdvYhpk.jpg)

1. **У XML документа должен быть корневой элемент**
2. **Все XML элементы должны иметь закрывающий тег**

```cs
<p>Это параграф.</p>
```

3. **Теги XML регистрозависимы**

```cs
<Message>Это неправильно</message>
<message>Это правильно</message>
```

4. **XML элементы должны соблюдать корректную вложенность**

```cs
<b><i>Это жирный и курсивный текст</i></b>
```

5. **Значения XML атрибутов должны заключаться в кавычки**

```cs
<note date=12/11/2007>
< note date="12/11/2007">
```

6. **Комментарии в XML**

```cs
<!-- Это комментарий --> 
```

**Синтаксически верный XML документ**

Если XML документ составлен в соответствии с приведенными синтаксическими правилами, то говорят, что это "синтаксически верный" XML документ.






















***

[**-->     HomeWork     <--**]()

**03.10.2017**

[**<-- **]() `=/=` [** -->**]()

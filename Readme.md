## Контрольная работа

### Задание:
___
**Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.**

*Пример:*

*["Hello", "2", "world", ":-)"] -> ["2", ":-)"]*

*["1234", "1567", "-2", "computer science"] -> ["-2"]*
____
## Описание решения:

### Для решения были использованы функции:

+ NumberOfElements - для определения размерности массива;
+ SelectedArray - для определения и внесения необходимых данных в новый массив;
+ PrintArray - для печати массива.
____

### Описание алгоритма:

+ задаем размерность первого массива;
+ создаем массив заданной размерности;
+ наполняем массив данными (ввод в консоли);
+ выводим на печать получившийся масив;
+ производим подсчета количества элементов в массиве, длина которых меньше либо равна 3 символа;
+ создаем новый массив размером, равным количеству подсчитанных элементов;
+ заполняем новый массив данными удовлетворяющими условию (длинна меньше или равна 3 символам);
+ выводим на печать получившийся массив.
___
*Блок-схема находится в [Sheme](Sheme.jpg)*
___
*Написанная программа находится в [Task](Task/Program.cs)*

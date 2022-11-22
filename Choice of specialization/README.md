
# _Задача:_

Написать программу, которая из имеющегося массива строк формирует массив строк, длина которых меньше либо либо равна трем символам. Первоначальный массив можем ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении задачи использовать массивы.
___

> ## Примеры
>
>["hello", "2", "world", ":-)"] -> ["2", ":-)"]
>
>["Russia", "Denmark", "Kazan"] -> []
___

## Алгоритм решения задачи

___

1. Объявляем два массива равной длинны.
2. Создаем метод, который производит выборку строк соответствующих заданному условию ( длинна строки < = 3), если строка не соответствует условию метод приступает к проверке следующей строки массива, если строка соответствует заданному критерию, то она заносится на "0" индекс второго массива. Для заполнения индексов второго массива в методе используем счетчик count. После присвоения строки удовлетворяющей условию из первого массива первому индексу вторго массива счетчик count увеличивается на 1 и возвращаемся к циклу for в котором i увеличивается на 1. Таким образом производим перебор всех строк в первом массиве и присвоение значений индексам второго массива строками из первого массива, соответствующими условию.
3. Схема алгоритма представлена в папке Schema.
4. Алгаритм реализован в папке: GB/Choice of specialization/Program.cs.
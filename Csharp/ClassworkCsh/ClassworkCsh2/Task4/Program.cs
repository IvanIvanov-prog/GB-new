// Имееется одномерный массив array из n злемнтов, требуется найти элемент массива, равный find
// Установить счетчик index в позицию 0
// Если array [index] = find, алгоритм завершил работу успеешно
// Увеличить index на 1
// Если index < n, то перейти к шагу 2. В противном случае алгоритм завершил работу безуспешно.


int[] array = { 11, 21, 71, 41, 55, 66, 71, 84 };
int n = array.Length; //задаем произвольную длину массива
int find = 71;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; // позволяет избежать вывода одинаковых цифр. выводдит 1 ое найденное и прекр. цикл.
    }
    index++;
}


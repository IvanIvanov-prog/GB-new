void FillArray(int[] collection) // метод задания случкайных значений
{ // оператор void обозначает метод который ничего не возвращает с ним не используется return
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10); //заполняет массив поизвольными значениями
        index++;
    }
}
void PrintArray(int[] col) // метод вывода значений
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
int IndexOf(int[] collection, int find)// метод нахождения индекса значения
{
    int count = collection.Length;
    int index = 0;
    int position = -1; //вводят значение 0 но -1 вводят для обхода случаев ввода значений не попадающих в массив
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}
int[] array = new int[10]; //задали массив с 10 элементами по умолчанию заполнен 0
FillArray(array); //строка запуска метода
array[4] = 4;//принудительный ввод значений для проверки исключения break
array[6] = 4;
PrintArray(array); // строка запуска метода
Console.WriteLine(); //выводим пустую строку, чтобы видеть что число не является частью вывода массива
int pos = IndexOf(array, 4); //стора ввода значения. которого ищем индекс
Console.WriteLine(pos);
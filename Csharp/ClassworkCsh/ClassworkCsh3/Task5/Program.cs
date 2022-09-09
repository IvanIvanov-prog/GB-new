// Сортировка массива
// найти позицию минимального элемента в неотсортированной части массива
// произвести обмен этого значения со значением первой неотсортированной позиции
// повторять пока есть неотсортированные элементы
int [] arr = { 1, 2, 3, 8, 4, 12, 46, 23, 46 };

void PrintArray(int[] array) // метод вывода массива
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
     Console.WriteLine();
}
PrintArray(arr);

void SelectionSort(int[] array)
{
for (int i = 0; i < array.Length - 1; i++) // -1 отнимается искусственно
{
    int minPosition = i;
    for (int j = i + 1; j < array.Length; j++)
    {
        if(array[j] < array[minPosition]) minPosition = j;
    }
int temporary = array[i];
array[i] = array[minPosition];
array[minPosition] = temporary;
}
}
PrintArray(arr);
SelectionSort (arr);
PrintArray(arr);
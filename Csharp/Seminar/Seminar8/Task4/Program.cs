/* Задайте двумерный массив из целых чисел. Напишите программу, 
которая удалит строку и столбец, на пересечении которых расположен 
наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим 
следующий массив:
9 4 2
2 2 6
3 4 7
*/
int[,] RemoveMinItem(int[,] arr)
{
    int[,] result = new int[arr.GetLength(0)-1,arr.GetLength(1)-1];
    int[] coords = FindMinimum(arr);
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (!(i == coords[0] || j == coords[1]))
            {
                int k = i;
                if (k > coords[0])
                {
                    k--;
                }
                int l = j;
                if (l > coords[1])
                {
                    l--;
                }
                result[k,l] = arr[i,j];
            }
        }
    }
    return result;
}
PrintArray(myArray);
int[] FindMinimum(int[,] arr)
{
    int[] coords = new int[2];
    coords[0] = 0;
    coords[1] = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i,j] < arr[coords[0],coords[1]])
            {
                coords[0] = i;
                coords[1] = j;
            }
        }
    }
    return coords;
}

int[,] myArray = GenerateArray(4,4,0,20);
PrintArray(myArray);
myArray = RemoveMinItem(myArray);
PrintArray(myArray);


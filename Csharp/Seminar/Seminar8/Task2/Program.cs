/* Задайте двумерный массив. Напишите программу, 
которая заменяет строки на столбцы. В случае, если это невозможно, 
программа должна вывести сообщение для пользователя.*/

int[,] TransposeArray(int[,] arr)
{
    int tmp = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = i; j < arr.GetLength(1); j++)
        {
            tmp = arr[i,j];
            arr[i,j] = arr[j,i];
            arr[j,i] = tmp;
        }
    }
    return arr;
}

int[,] myArray = GenerateArray(4, 4, 1, 5);
PrintArray(myArray);
myArray = TransposeArray(myArray);
PrintArray(myArray);


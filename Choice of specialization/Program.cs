/* Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна трем символам.
Первоначальный массив можем ввести с клавиатуры, либо задать на старте выполнения прграммы.
При решении использовать массивы. */ 

string[] array1 = new string[5] {"1234", "1567", "-2", "computer science", ":-)"};
string[] array2 = new string[array1.Length];
void SecondArrayWithIF(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArrayWithIF(array1, array2);
PrintArray(array2);

// string[,] table = new string[2, 5];
// /table[0, 0] table[0, 1] table[0, 2] table[0, 4] 
// /table[1, 0] table[1, 1] table[1, 2] table[1, 4] 
// /table[1, 2] = "Слово";
//for (int rows = 0; rows < 2; rows++)
//{
//for (int columns = 0; columns < 5; columns++)
//{
//    Console.WriteLine($"-{table[rows, columns]}-");
//}
//}

// int[,] matrix = new int[3, 4];
// for (int i = 0; i < 3; i++) // внешний цукл по строкам ведет счет
//{
//for (int j = 0; j < 4; j++) // внутренний цукл по строкам ведет счет по столбцам
//{
//Console.Write($"{matrix[i, j]} ");
//}
//Console.WriteLine();
//}

/// Использовкание конструкции matrix.GetLength
//int[,] matrix = new int[3, 4];
//for (int i = 0; i < matrix.GetLength(0); i++) // (0) задаем для начала отсчета)
//{
//for (int j = 0; j < matrix.GetLength(1); j++) // (1) задаем для начала отсчета)
//{
//    Console.Write($"{matrix[i, j]} ");
//}
//Console.WriteLine();
//}

/// Создаем метод создания матрицы

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // (0) задаем для начала отсчета)
    {
        for (int j = 0; j < matr.GetLength(1); j++) // (1) задаем для начала отсчета)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] matr) // заполнение матрицы случайными числами от 1 до 10
{
    for (int i = 0; i < matr.GetLength(0); i++) // (0) задаем для начала отсчета)
    {
        for (int j = 0; j < matr.GetLength(1); j++) // (1) задаем для начала отсчета)
        {
            matr[i, j] = new Random().Next(1, 10); // [1; 10)
        }

    }

}

int[,] matrix = new int[3, 4];
PrintArray (matrix); // выводит "0" для проверки
FillArray (matrix);
Console.WriteLine(); // строка между массивами
PrintArray (matrix);
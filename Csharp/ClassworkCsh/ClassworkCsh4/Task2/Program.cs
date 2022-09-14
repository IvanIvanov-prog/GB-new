
// картинки нет работать не будет

// Метод вывода картинки
void PrintImage(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++) // (0) задаем для начала отсчета)
    {
        for (int j = 0; j < image.GetLength(1); j++) // (1) задаем для начала отсчета)
        {
            // Console.Write($"{matr[i, j]} ");
            if(imagextern[i,j] == 0) Console.Write($" ");
            else Console.Write($"+");
        }
        Console.WriteLine();
    }
}
PrintImage(pic);
// Метод закрашивания картинки
void FillImage(int row, int col)
{
    if(pic[row, col] == 0)
    {
    pic[row, col] = 1;       // закрашиваем "1"-ой
    FillImage(row - 1, col); // смещаемся вверх
    FillImage(row, col - 1); // смещаемся влево
    FillImage(row + 1, col); // смещаемся вниз
    FillImage(row, col + 1); // смещаемся вправо
    }
}
FillImage(13, 13); // координаты точки должны быть внутри области подлежащей закрашиванию
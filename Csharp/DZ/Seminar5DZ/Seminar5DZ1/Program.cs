/* Задайте массив заполненный случайными положительными трёхзначными числами. 
*  Напишите программу, которая покажет количество чётных чисел в массиве.
*  [345, 897, 568, 234] -> 2
*/
// Метод 4 что то принимает и что то возвращает 
//string Method4(int count, string text)
/*{
    string result = String.Empty; // задаем первую строку пустой
    for (int i = 0; i < count; i++) //for(инициализация счетчика, проверка условия, инкримент)
    {
        result = result + text;
        
    }
    return result;
}
string res = Method4(10, "ZZZ"); //10 заданное количество вывода текста
System.Console.WriteLine(res);
*/
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Вот наш массив: ");
PrintArray(numbers);
int count = 0;

for (int z = 0; z < numbers.Length; z++)
    if (numbers[z] % 2 == 0)
        count++;

Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");

void FillArrayRandomNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100, 1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

// Напишите программу замены элементов массива: положительные элементы замените 
// на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]


const int NEGATIVE_VALUE = -1;
const int POSITIVE_VALUE = 1;

int Prompt(string message)
{
    Console.Write(message);
    bool isDigit = int.TryParse(Console.ReadLine(), out int number);
    if (isDigit){
        return number;
    }
    throw new Exception("Вы ввели не число");
}
int[] GenerateArray(int length, int minRandom, int maxRandom)
{
    Random rnd = new Random();
    int[] answer = new int[length];
    for (int i = 0; i < answer.Length; i++)
    {
        answer[i] = rnd.Next(minRandom, maxRandom + 1);
    }
    return answer;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]+ "\t");
    }
    System.Console.WriteLine();
}

int SumElements(int[] array, int sign = POSITIVE_VALUE)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((array[i] * sign) > 0)
        {
            sum += array[i];
        }
    }

    return sum;
}

const int MIN_ELEMENTS = -9;
const int MAX_ELEMENTS = 9;

int length = Prompt("Введите длину массива >");
int[] array = GenerateArray(length, MIN_ELEMENTS, MAX_ELEMENTS);
PrintArray(array);
System.Console.WriteLine($"Сумма положительных значений равна {SumElements(array)}");
System.Console.WriteLine($"Сумма отрицательных значений равна {SumElements(array, NEGATIVE_VALUE)}");


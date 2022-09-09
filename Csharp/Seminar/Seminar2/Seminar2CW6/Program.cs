// Напишите программу, которая будет принимать на вход пять чисел и выводить сумму и среднее арифметическое этих чисел.
// 2, 5, 6, 8, 1 -> сумма 22, среднее 4,4

Console.WriteLine("Привет! Введите число А");
int Prompt(string messege)
{
    Console.Write(messege);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}
int number1 = Prompt("Введите число 1 > ");
int number2 = Prompt("Введите число 2 > ");
int number3 = Prompt("Введите число 3 > ");
int number4 = Prompt("Введите число 4 > ");
int number5 = Prompt("Введите число 5 > ");
int summ = number1 + number2 + number3 + number4 + number5;
double average = summ / 5;
System.Console.WriteLine($"{number1}, {number2}, {number3}, {number4}, {number5}, average={(number1+number2+number3+number4+number5)/5}");

// int[] numbers = new int[5];
// for(int i=0; i<numbers.Length; i++)
// {
//    numbers[i] = Prompt($"Введите число from 100 to 999{i+1} > ");
// }
// int sum = 0;
// double average;
// for(int i=0; i<numbers.Length; i++)
// {
//     sum += numbers[i];
// }
// average = sum/numbers.Length;
// System.Console.WriteLine($"summ={sum}, average={average}");

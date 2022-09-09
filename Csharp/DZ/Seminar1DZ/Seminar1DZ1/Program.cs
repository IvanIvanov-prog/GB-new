// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Привет! Введите два числа А и B");
int Prompt(string messege)
{
    Console.Write(messege);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}
int firstValue = Prompt("Введите число А > ");
int secondValue = Prompt("Введите число B > ");
if (firstValue > secondValue)
{
    System.Console.WriteLine($"Максимальным числом является число А равное {firstValue}");
}else 
{
    System.Console.WriteLine($"Максимальным числом является число B равное {secondValue}");
}

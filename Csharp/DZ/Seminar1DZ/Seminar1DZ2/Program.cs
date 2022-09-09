//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Привет! Введите два числа А,B,C");
int Prompt(string messege)
{
    Console.Write(messege);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}
int firstValue = Prompt("Введите число А > ");
int secondValue = Prompt("Введите число B > ");
int thirdValue = Prompt("Введите число C > ");

int max = firstValue;

if (firstValue > max) max = firstValue;
if (secondValue > max) max = secondValue;
if (thirdValue > max) max = thirdValue;

System.Console.WriteLine($"Максимальное число равно > {max}");


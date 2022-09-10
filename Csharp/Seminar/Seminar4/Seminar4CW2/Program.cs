// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// создаем рабочий алгоритм, переводим его в метод
int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int CountDigit(int number)
{
int count = 0;
if (number ==0)
{
    return 1;
}
while (number != 0)
{
    number = number / 10;
    count++;
}
return count;
}
int number = Prompt("Введите число ->");
System.Console.WriteLine(CountDigit(number));





// int number = Prompt("Введите число ->");
// int count = 0;
// while (number != 0) // выпоолняется цикл пока вып усл
//{
//    number = number / 10;
 //   count++;
//}
//System.Console.WriteLine(count);
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
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
int Exponentiation(int firstValue, int secondValue)
{
  int result = 1;
  for(int i=1; i <= secondValue; i++)
  {
    result = result * firstValue;
  }
    // int result = Math.Pow(firstValue, secondValue);
    return result;
}
int exponentiation = Exponentiation(firstValue, secondValue);
Console.WriteLine($"Число > {firstValue}, возведенное в > {secondValue}, равно = {exponentiation}");


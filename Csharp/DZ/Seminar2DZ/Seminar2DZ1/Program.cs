//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Привет! Введите трёхзначное число");
int Prompt(string messege)
{
    Console.Write(messege);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}
int value = Prompt("Введите число > ");
void secondchislo()
{
    int p = value;
    int a = (p/10)%10;
    System.Console.WriteLine($"Вторая цифра ={a}");
}
secondchislo();

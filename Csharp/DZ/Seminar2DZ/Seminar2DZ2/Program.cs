// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
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
    int a1 = p/100;
    int a2 = (p/10)%10;
    int a3 = p%10;
    System.Console.WriteLine($"новая цифра ={a1*10 + a3}");
}
secondchislo();

// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
// (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
Console.WriteLine("Привет! Введите число А");
int Prompt(string messege)
{
    Console.Write(messege);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}
int firstValue = Prompt("Число А > ");
Console.WriteLine(firstValue % 2 == 0 ? "Четное" : "Не четное");











// {
  //  if (value >= 0)
  //  {
    //    value = value - 2;
   // }
  //  if (value < 0)
  //  {
  //       value = value + 2;
  //  } 
 //   }
  //  count = count + 1;
// }
// else
// {
   //  System.Console.WriteLine($"Введенное число {value} является -> Не четным");
// }
// if value = 0;
// System.Console.WriteLine($"Введенное число является -> Четным");

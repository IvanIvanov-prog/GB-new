// Метод 1 типа ничего не принимает ничего не возвращает VOID
void Method()
{
    Console.WriteLine("Автор......");
}
Method(); // строка вцызова метода, без скобок работать не будет




// Метод 2 типа что тот принимает ничего не возвращает VOID
void Method2(string msg)
{
    Console.WriteLine(msg);
}
 Method2("Текст сообщения");
// Метод 2 типа что тот принимает ничего не возвращает VOID
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++; //инкримент - увеличение счетчика на 1, декримент - уменьшение счетчика на 1
    }
}
Method21("Текст сообщения", 4); //цифра 4 определ количество выводимых сообщений, при count в инкрименте 4 не работала
// Method21(count: 4, msg: "Новый текст"); // Можем явно указывать какому аргументу какое значение хотим присвоить
// в этом случпае писать аргументы по порядку не обязательно

// Метод 3 ничего не принимает что то возвращает 
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

// Метод 4 что то принимает и что то возвращает 
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty; // задаем первую строку пустой
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "Текст"); //10 заданное количество вывода текста
System.Console.WriteLine(res);

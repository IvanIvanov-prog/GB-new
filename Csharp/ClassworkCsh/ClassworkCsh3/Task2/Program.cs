// Метод 4 что то принимает и что то возвращает 
string Method4(int count, string text)
{
    string result = String.Empty; // задаем первую строку пустой
    for (int i = 0; i < count; i++) //for(инициализация счетчика, проверка условия, инкримент)
    {
        result = result + text;
        
    }
    return result;
}
string res = Method4(10, "ZZZ"); //10 заданное количество вывода текста
System.Console.WriteLine(res);

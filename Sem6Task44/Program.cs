// Задача №44
// Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

// Запрос данных у пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

// Вывод полученных данных
void PrintData(string msg)
{
    Console.WriteLine(msg);
}

// Метод создания чисел Фибоначчи
string FibNum(int num)
{
    string res = "0 1";
    int first = 0;
    int last = 1;
    for (int i = 2; i < num; i++)
    {
       res = res + " " + (first + last).ToString();
       (first, last) = (last, first + last);
       // int buf = 0;
       // buf = last;
       // last = last + first;
       // first = last;
    }
    return res;
}

int num = ReadData("Введите число: ");
string res = FibNum(num);
PrintData(res);

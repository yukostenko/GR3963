// Задача №25 Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// * Написать калькулятор с операциями +, -, /, * и возведение в степень.

// Запрос данных у пользователя
int ReadData(string msg)
{
    // Выводим сообщение
    Console.WriteLine(msg);
    // Считываем число
    int inputNum = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return inputNum;
}

// Вывод данных
void PrintData(string msg)
{
    Console.WriteLine(msg);
}

// Возведение числа А в степень В
long Pow (int a, int b)
{
    long res = 1;
    while (b > 0)
    {
       res = res*a;
       b=b-1;
    }
    return res;
}

int a =  ReadData("Введите число A: ");
int b =  ReadData("Введите число B: ");

long res = Pow(a, b);

PrintData("Число A в степени B равно " + res);

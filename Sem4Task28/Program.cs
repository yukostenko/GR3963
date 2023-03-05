// Напишите программу, которая принимает на вход
// число N и выдаёт произведение чисел от 1 до N.

using System.Numerics;

// Запрос данных у пользователя
int ReadData(string msg)
{
    // Выводим сообщение
    Console.WriteLine(msg);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// Вывод полученных данных
void PrintData(string msg, BigInteger num)
{
    Console.WriteLine(msg + num);
}

// Метод произведения чисел
BigInteger FactorCalc(int num)
{
    BigInteger res = 1;
    for (int i = 2; i <= num; i++)
    {
        res *= i;
    }
    return res;
}

int number = ReadData("Введите число N: ");
BigInteger result = FactorCalc(number);
PrintData("Произведение чисел от 1 до N равно: ", result);
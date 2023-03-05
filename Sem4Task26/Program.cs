// Напишите программу, которая принимает на вход
// число и выдаёт количество цифр в числе.

// Запрос данных у пользователя
int ReadData(string num)
{
    // Выводим сообщение
    Console.WriteLine(num);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// Вывод полученных данных
void PrintData(string msg, int num)
{
    Console.WriteLine(msg + num);
}

// Метод подсчета цифр в числе
int DigitSome(int num)
{
    int res = 0;
    while (num > 0)
    {
        num /= 10; // num = num/10;
        res += 1;// res = res + 1;
    }
    return res;
}

int number = ReadData("Введите число: ");
int res = DigitSome(number);
PrintData("Количество чисел в числе: ", res);

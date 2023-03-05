// Задача №27 Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// * Сделать оценку времени алгоритма через вещественные числа и строки.


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

// Метод подсчета суммы цифр в числе
int SumDigits(int num)
{
    int sum = 0;
    if (int i = 0; i <= num; i++;)
    {
    sum += i;
}
return sum;
}

int num = ReadData("Введите число: ");
int sum = SumDigits(num);
PrintData("Сумма цифр в числе равна: ", sum);
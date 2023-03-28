// Задача 64: Задайте значение N.
// Напишите программу, которая выведет все натуральные числа
// в промежутке от 1 до N. Выполнить с помощью рекурсии.
// N = 5 -> "1, 2, 3, 3, 4"
// N = 8 -> "1, 2, 3, 4, 5, 6, 7, 8"

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
// LineGenRec(1)
// LineGenRec(2)
// LineGenRec(3)
// LineGenRec(4)
// LineGenRec(5)

void LineGenRec(int num)
{
    if (num == 0) // точка остановки рекурсии
    {
    }
    else
    {
        LineGenRec(num-1);//следующий вызов
        Console.Write(" " + num);
    }
}

int number = ReadData("Введите число N: ");
LineGenRec(number);